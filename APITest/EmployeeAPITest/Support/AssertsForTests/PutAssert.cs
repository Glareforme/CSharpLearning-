using EmployeeAPITest.Support.CreateExpectedResponce;
using EmployeeAPITest.Support.Models;
using System.Text.Json;

namespace EmployeeAPITest.Support.AssertsForTests
{
    internal class PutAssert
    {
        WorkWithPutResponce putResponce = new WorkWithPutResponce();

        public bool IsUpdatedRecordInDBCorrectResponce(string actualResponce)
        {
            var expectedResult = putResponce.EmployeeResponceModelForSuccessfullPutRequestById();
            var actualResult = JsonSerializer.Deserialize<UpdateModelResponce>(actualResponce);
            if (expectedResult.status.Equals(actualResult.status) && expectedResult.message.Equals(actualResult.message))
            {
               return true;
            }
            return false;
        }
        public bool IsUpdatedRecordInDBCorrectResponce(EmployeeResponceModel expectedResult, string actualResponce)
        {
            var actualResult = JsonSerializer.Deserialize<UpdateModelResponce>(actualResponce);
            if(expectedResult.status.Equals(actualResult.status) && expectedResult.message.Equals(actualResult.message))
            {
                return true;
            }
            return false;
        }
    }
}
