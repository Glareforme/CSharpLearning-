using APITest.Models;
using EmployeeAPITest.Support.Models;
using EmployeeAPITest.Support.WorkWithResponce;
using System.Text.Json;
using APITest.Constants;

namespace EmployeeAPITest.Support.AssertsForTests
{
    internal class GetAssert
    {
        public bool IsGetRecordByIdCorrectResponce(int userId, string actualResponce)
        {
            var expectedResult = WorkWithGetResponce.ExpectedResponceModelForSuccessfullGetByIdRequest(userId);
            var actualResult = JsonSerializer.Deserialize<EmployeeResponceModel>(actualResponce);
            if (expectedResult.status.Equals(actualResult.status) && expectedResult.message.Equals(actualResult.message))
            {
                return true;
            }
            return false;
        }
        public bool IsResponceContainsInfoAboutEmployee(string actualResponce)
        {
            var actualResult = JsonSerializer.Deserialize<UpdateModelResponce>(actualResponce);
            if (actualResult.data == null)
            {
                return true;
            }
            return false;
        }
        public bool ReturnMassageWithException(string actualResponce)
        {
            var actualResult = JsonSerializer.Deserialize<ResponceModelError>(actualResponce);
            if (actualResult.status.Equals(ResponceConstants.ErrorStatus) && actualResult.code.Equals(ResponceConstants.Status400))
            {
                return true;
            }
            return false;
        }
    }
}
