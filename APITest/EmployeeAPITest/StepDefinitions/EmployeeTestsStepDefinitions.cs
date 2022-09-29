using APITest.Constants;
using NUnit.Framework;
using EmployeeAPITest.Support;
using EmployeeAPITest.Support.AssertsForTests;
using EmployeeAPITest.Drivers;
using EmployeeAPITest.Support.WorkWithResponce;

namespace EmployeeAPITest.StepDefinitions
{
    public class EmployeeData
    {
        public int EmployeeId;
        public string? Responce;
    }

    [Binding]
    public class EmployeeTestsStepDefinitions : EmployeeRequestController
    {
        private readonly EmployeeData employeeData;
        public EmployeeTestsStepDefinitions(EmployeeData employeeData)
        {
            this.employeeData = employeeData;
        }
        [When(@"Send api request with employeee (.*) for get information about him")]
        public async Task WhenSendGETRequestWithEmployeeForGetInformationAboutHim(int userId)
        {
            var actualResponce = await this.GetEmployeeByIdAsync(userId);
            employeeData.Responce = actualResponce;
            employeeData.EmployeeId = userId;
        }

        [Then(@"The expected user data and the data from the response are the same \('([^']*)'\)")]
        public void ThenTheExpectedUserDataAndTheDataFromTheResponseAreTheSame(string method)
        {
            GetAssert getAssert = new GetAssert();
            PostAssert postAssert = new PostAssert();
            PutAssert putAssert = new PutAssert();

            bool result = false;

            if (method.Equals(ResponceConstants.GetMethod))
            {
                result = getAssert.IsGetRecordByIdCorrectResponce(employeeData.EmployeeId, employeeData.Responce);
            }
            else if (method.Equals(ResponceConstants.PostMethod))
            {
                result = postAssert.IsCreateRecordInDBCorrectResponce(employeeData.Responce);
            }
            else if (method.Equals(ResponceConstants.PutMethod))
            {
                result = putAssert.IsUpdatedRecordInDBCorrectResponce(employeeData.Responce);
            }
            Assert.IsTrue(result);
        }

        [Given(@"Send api request with employee data for create new record in database with '([^']*)'")]
        [When(@"Send api request with employee data for create new record in database with '([^']*)'")]
        public async Task WhenSendApiRequestWithEmployeeDataForCreateNewRecordInDatabaseWith(string typeOfRequest)
        {
            var actualResponce = await this.PostCreateEmployeeRecord();
            employeeData.Responce = actualResponce;
        }

        [When(@"Send api request with employee (.*) and new data for update information in database")]
        public async Task WhenSendApiRequestWithEmployeeIdAndNewDataForUpdateInformationInDatabase(int userId)
        {
            var actualResponce = await this.PutUpdateEmployeeRecord(userId);
            employeeData.Responce = actualResponce;
            employeeData.EmployeeId = userId;
        }

        [Given(@"Send api request with employee (.*) for delete record from database")]
        [When(@"Send api request with employee (.*) for delete record from database")]
        public async Task WhenSendApiRequestWithEmployeeIdForDeleteRecordFromDatabase(int userId)
        {
            var actualResponce = await this.DeleteRecordFromDatabase(userId);
            employeeData.Responce = actualResponce;
            employeeData.EmployeeId = userId;
        }

        [Then(@"Record with employee data has been deleted from database")]
        public void ThenRecordWithEmployeeDataHasBeenDeletedFromDatabase()
        {
            DeleteAssert deleteAssert = new DeleteAssert();
            Assert.IsTrue(deleteAssert.IsGetRecordByIdCorrectResponce(employeeData.Responce));
        }

        [When(@"Send api request with just created employeee id for get information about him")]
        public async Task WhenSendApiRequestWithJustCreatedEmployeeeIdForGetInformationAboutHim()
        {
            WorkWithPostResponce responce = new WorkWithPostResponce();
            var justCreatedEmployeeID = responce.GetIdJustCreatedEmployee(employeeData.Responce);
            var getInfo = await this.GetEmployeeByIdAsync(justCreatedEmployeeID);
            employeeData.Responce = getInfo;
        }

        [Then(@"Responce does not contain added information")]
        public void ThenResponceDoesNotContainAddedInformation()
        {
            GetAssert assert = new GetAssert();
            Assert.IsTrue(assert.IsResponceContainsInfoAboutEmployee(employeeData.Responce));
        }

        [When(@"Send api request with id just deleted employee for get information about him")]
        public async Task WhenSendApiRequestWithIdJustDeletedEmployeeForGetInformationAboutHim()
        {
            var responce = await this.GetEmployeeByIdAsync(employeeData.EmployeeId);
            employeeData.Responce = responce;
        }

        [Then(@"Database still contain data information about deleted employee")]
        public void ThenDatabaseStillContainDataInformationAboutDeletedEmployee()
        {
            DeleteAssert deleteAssert = new DeleteAssert();
            Assert.IsTrue(deleteAssert.IsRecordStillInDataBase(employeeData.Responce));
        }

        [Given(@"Send api request with employeee (.*) for get current information about him")]
        public async Task GivenSendApiRequestWithEmployeeeIdForGetCurrentInformationAboutHim(int userId)
        {
            var actualREsponce = await this.DeleteRecordFromDatabase(userId);
        }

        [Then(@"Information about user with this id has not been updated")]
        public async Task ThenInformationAboutUserWithThisIdHasNotBeenUpdated()
        {
            GetAssert getAssert = new GetAssert();
            var actualData = await this.GetEmployeeByIdAsync(employeeData.EmployeeId);
            Assert.IsTrue(!getAssert.IsGetRecordByIdCorrectResponce(employeeData.EmployeeId, employeeData.Responce));
        }
        [Then(@"In responce return message with exception")]
        public void ThenInResponceReturnMessageWithException()
        {
            GetAssert getAssert = new GetAssert();
            Assert.IsTrue(getAssert.ReturnMassageWithException(employeeData.Responce));
        }

    }
}
