using APITest.Constants;
using APITest.Models;
using EmployeeAPITest.Support.Models;
using EmployeeAPITest.Support.WorkWithResponce;
using System.Text.Json;

namespace EmployeeAPITest.Support.AssertsForTests
{
    internal class PostAssert
    {
        public bool IsCreateRecordInDBCorrectResponce(string actualResponce)
        {
            var expectedResult = WorkWithPostResponce.ExpectedResponceModelForSuccessfullCreateIntDB();
            var actualResult = JsonSerializer.Deserialize<EmployeeResponceModel>(actualResponce);
            if (expectedResult.status.Equals(actualResult.status) && expectedResult.message.Equals(actualResult.message))
            {
                return true;
            }
            return false;
        }
        public bool IsCreateRecordInDBCorrectResponce(EmployeeResponceModel expectedResult, string actualResponce)
        {
            var actualResult = JsonSerializer.Deserialize<EmployeeResponceModel>(actualResponce);
            if(expectedResult.status.Equals(actualResult.status) && expectedResult.message.Equals(actualResult.message))
            {
                return true;
            }
            return false; 
        }
        public bool IsExceptionReturn(string actualResponce)
        {
            var actualResult = JsonSerializer.Deserialize<ResponceModelError>(actualResponce);
            if (actualResult.status.Equals(ResponceConstants.ErrorStatus))
            {
                return true;
            }
            return false;
        }
    }
}
