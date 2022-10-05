using APITest.Constants;
using NUnit.Framework;
using EmployeeAPITest.Support.Models;
using EmployeeAPITest.Support.AssertsForTests;
using EmployeeAPITest.Drivers;
using EmployeeAPITest.Support.WorkWithResponce;
using TechTalk.SpecFlow.Assist;
using EmployeeAPITest.Support.CreateExpectedResponce;

namespace EmployeeAPITest.StepDefinitions
{
    public class EmployeeResponceInfo
    {
        public int EmployeeId;
        public string? Responce;
    }

    [Binding]
    public class EmployeeTestsStepDefinitions
    {
        EmployeeRequestController controller = new EmployeeRequestController();
        private readonly EmployeeResponceInfo employeeData;

        public EmployeeTestsStepDefinitions(EmployeeResponceInfo employeeData)
        {
            this.employeeData = employeeData;
        }

        [When(@"the user requests the employee's information by the (.*)")]
        public async Task WhenSendGETRequestWithEmployeeForGetInformationAboutHim(int userId)
        {
            userId = RequestID.FirstSearchId;
            var actualResponce = await controller.GetEmployeeByIdAsync(userId);
            employeeData.Responce = actualResponce;
            employeeData.EmployeeId = userId;
        }

        [Then(@"the expected user data and the data from the response are the same \('([^']*)'\)")]
        public void ThenTheExpectedUserDataAndTheDataFromTheResponseAreTheSame(string method, Table table)
        {
            GetAssert getAssert = new GetAssert();
            PostAssert postAssert = new PostAssert();
            PutAssert putAssert = new PutAssert();
            bool result = false;
            var expectedData = table.CreateSet<EmployeeDataFromTable>().ToList();
          
            if (method.Equals(ResponceConstants.GetMethod))
            {
                var expectedResponce = WorkWithGetResponce.ExpectedResponceModelForSuccessfullGetByIdRequest(expectedData, employeeData.EmployeeId);
                result = getAssert.IsGetRecordByIdCorrectResponce(expectedResponce, employeeData.Responce);
            }
            else if (method.Equals(ResponceConstants.PostMethod))
            {
                var expectedResponce = WorkWithPostResponce.ExpectedResponceModelForSuccessfullCreateIntDB(expectedData[0]);
                result = postAssert.IsCreateRecordInDBCorrectResponce(expectedResponce, employeeData.Responce);
            }
            else if (method.Equals(ResponceConstants.PutMethod))
            {
                var expectedResponce = WorkWithPutResponce.EmployeeResponceModelForSuccessfullPutRequestById(expectedData[0]);
                result = putAssert.IsUpdatedRecordInDBCorrectResponce(expectedResponce, employeeData.Responce);
            }
            Assert.IsTrue(result);
        }

        [Given(@"send api request with employee data to create a new record in the database with '([^']*)'")]
        [When(@"the user creates the employee's information  with '([^']*)'")]
        public async Task WhenSendApiRequestWithEmployeeDataForCreateNewRecordInDatabaseWith(string typeOfRequest)
        {
            var actualResponce = await controller.PostCreateEmployeeRecord();
            employeeData.Responce = actualResponce;
        }

        [When(@"the user sends api request with employee (.*) and new data for update information in the database")]
        public async Task WhenSendApiRequestWithEmployeeIdAndNewDataForUpdateInformationInDatabase(int userId)
        {
            userId = RequestID.FirstSearchId;
            var actualResponce = await controller.PutUpdateEmployeeRecord(userId);
            employeeData.Responce = actualResponce;
            employeeData.EmployeeId = userId;
        }

        [Given(@"send api request with employee (.*) to delete record from the database")]
        [When(@"the user deletes the employee's information by the (.*) from the database")]
        public async Task WhenSendApiRequestWithEmployeeIdForDeleteRecordFromDatabase(int userId)
        {
            userId = RequestID.FirstSearchId;
            var actualResponce = await controller.DeleteRecordFromDatabase(userId);
            employeeData.Responce = actualResponce;
            employeeData.EmployeeId = userId;
        }

        [Then(@"record with employee data has been deleted from database")]
        public void ThenRecordWithEmployeeDataHasBeenDeletedFromDatabase()
        {
            DeleteAssert deleteAssert = new DeleteAssert();
            Assert.IsTrue(deleteAssert.IsGetRecordByIdCorrectResponce(employeeData.Responce));
        }

        [When(@"send api request with just created employee id for getting information about him")]
        public async Task WhenSendApiRequestWithJustCreatedEmployeeeIdForGetInformationAboutHim()
        {
            WorkWithPostResponce responce = new WorkWithPostResponce();
            var justCreatedEmployeeID = responce.GetIdJustCreatedEmployee(employeeData.Responce);
            var getInfo = await controller.GetEmployeeByIdAsync(justCreatedEmployeeID);
            employeeData.Responce = getInfo;
        }

        [Then(@"response does not contain added information")]
        public void ThenResponceDoesNotContainAddedInformation()
        {
            GetAssert assert = new GetAssert();
            Assert.IsTrue(assert.IsResponceContainsInfoAboutEmployee(employeeData.Responce));
        }

        [When(@"the user send api request with id just deleted the employee for getting information about him")]
        public async Task WhenSendApiRequestWithIdJustDeletedEmployeeForGetInformationAboutHim()
        {
            var responce = await controller.GetEmployeeByIdAsync(employeeData.EmployeeId);
            employeeData.Responce = responce;
        }

        [Then(@"the database still contains data information about deleted employee")]
        public void ThenDatabaseStillContainDataInformationAboutDeletedEmployee()
        {
            DeleteAssert deleteAssert = new DeleteAssert();
            Assert.IsTrue(deleteAssert.IsRecordStillInDataBase(employeeData.Responce));
        }

        [Given(@"the user delete the employee's information by the (.*)")]
        public async Task GivenSendApiRequestWithEmployeeeIdForGetCurrentInformationAboutHim(int userId)
        {
            userId = RequestID.FirstSearchId;
            var actualREsponce = await controller.DeleteRecordFromDatabase(userId);
        }

        [Then(@"information about the user with this id has not been updated")]
        public async Task ThenInformationAboutUserWithThisIdHasNotBeenUpdated()
        {
            GetAssert getAssert = new GetAssert();
            var actualData = await controller.GetEmployeeByIdAsync(employeeData.EmployeeId);
            Assert.IsTrue(!getAssert.IsGetRecordByIdCorrectResponce(employeeData.EmployeeId, employeeData.Responce));
        }

        [Then(@"in response return message with the exception")]
        public void ThenInResponceReturnMessageWithException()
        {
            GetAssert getAssert = new GetAssert();
            Assert.IsTrue(getAssert.ReturnMassageWithException(employeeData.Responce));
        }
    }
}
