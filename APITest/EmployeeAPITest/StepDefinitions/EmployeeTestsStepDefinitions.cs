using APITest.Constants;
using NUnit.Framework;
using EmployeeAPITest.Support;
using EmployeeAPITest.Support.AssertsForTests;
using EmployeeAPITest.Drivers;

namespace EmployeeAPITest.StepDefinitions
{
    public class PersonData
    {
        public string FirstName;
        public string LastName;
    }
    [Binding]
    public class EmployeeTestsStepDefinitions : EmployeeRequestController
    {
        [When(@"Send api request with employeee (.*) for get information about him")]
        public async void WhenSendGETRequestWithEmployeeForGetInformationAboutHim(int userId)
        {
            var actualResponce = await this.GetEmployeeByIdAsync(userId);
        }

        [Then(@"The expected user data and the data from the response are the same \('([^']*)'\)")]
        public void ThenTheExpectedUserDataAndTheDataFromTheResponseAreTheSame(string method)
        {
            GetAssert getAssert = new GetAssert();

            bool result = false;

            if (method.Equals(ResponceConstants.GetMethod))
            {
                result = getAssert.IsExpectedAndActualResponcesame(ScenarioContext.Current.Get<int>(ConstKeysForScenarioContext.UserIdForGetResponce),
                      ScenarioContext.Current.Get<string>(ConstKeysForScenarioContext.GetInfoByIdResponce));
            }
            else if (method.Equals(ResponceConstants.PostMethod))
            {
                result = true;
            }
            else if (method.Equals(ResponceConstants.PutMethod))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [Given(@"Send api request with employee data for create new record in database with '([^']*)'")]
        [When(@"Send api request with employee data for create new record in database with '([^']*)'")]
        public async void WhenSendApiRequestWithEmployeeDataForCreateNewRecordInDatabaseWith(string p0)
        {
            var actualResponce = await this.PostCreateEmployeeRecord();
        }

        [When(@"Send api request with employee (.*) and new data for update information in database")]
        public async void WhenSendApiRequestWithEmployeeIdAndNewDataForUpdateInformationInDatabase(int userId)
        {
            var actualResponce = await this.PutUpdateEmployeeRecord(userId);
        }

        [Given(@"Send api request with employee id for delete record from database")]
        [When(@"Send api request with employee id for delete record from database")]
        public void WhenSendApiRequestWithEmployeeIdForDeleteRecordFromDatabase()
        {
            throw new PendingStepException();
        }

        [Then(@"Record with employee data has been deleted from database")]
        public void ThenRecordWithEmployeeDataHasBeenDeletedFromDatabase()
        {
            throw new PendingStepException();
        }

        [Then(@"In responce return message with exception")]
        public void ThenInResponceReturnMessageWithException()
        {
            throw new PendingStepException();
        }
        [When(@"Send api request with just created employeee id for get information about him")]
        public void WhenSendApiRequestWithJustCreatedEmployeeeIdForGetInformationAboutHim()
        {
            throw new PendingStepException();
        }

        [Then(@"Responce does not contain added information")]
        public void ThenResponceDoesNotContainAddedInformation()
        {
            throw new PendingStepException();
        }

        [When(@"Send api request with id just deleted employee for get information about him")]
        public void WhenSendApiRequestWithIdJustDeletedEmployeeForGetInformationAboutHim()
        {
            throw new PendingStepException();
        }

        [Then(@"Database still contain data information about deleted employee")]
        public void ThenDatabaseStillContainDataInformationAboutDeletedEmployee()
        {
            throw new PendingStepException();
        }

        [Given(@"Send api request with employeee id for get current information about him")]
        public void GivenSendApiRequestWithEmployeeeIdForGetCurrentInformationAboutHim()
        {
            throw new PendingStepException();
        }

        [Then(@"Information about user with this id has not been updated")]
        public void ThenInformationAboutUserWithThisIdHasNotBeenUpdated()
        {
            throw new PendingStepException();
        }
    }
}
