using EmployeeAPITest.Support.Models;
using EmployeeAPITest.Support.WorkWithResponce;
using System.Text.Json;

namespace EmployeeAPITest.Support.AssertsForTests
{
    internal class PostAssert
    {
        WorkWithPostResponce workWithPostResponce = new WorkWithPostResponce();
        public bool IsCreateRecordInDBCorrectResponce(string actualResponce)
        {
            var expectedResult = workWithPostResponce.ExpectedResponceModelForSuccessfullCreateIntDB();
            var actualResult = JsonSerializer.Deserialize<EmployeeResponceModel>(actualResponce);
            if (expectedResult.status.Equals(actualResult.status) && expectedResult.message.Equals(actualResult.message))
            {
                return true;
            }
            return false;
        }
    }
}
