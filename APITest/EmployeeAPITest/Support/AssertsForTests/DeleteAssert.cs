using EmployeeAPITest.Support.CreateExpectedResponce;
using EmployeeAPITest.Support.Models;
using System.Text.Json;

namespace EmployeeAPITest.Support.AssertsForTests
{
    internal class DeleteAssert
    {
        public bool IsGetRecordByIdCorrectResponce(string actualResponce)
        {
            var expectedResult = WorkWithDeleteResponce.ExpectedResponceModelForSuccessfullDeleteByIdRequest();
            var actualResult = JsonSerializer.Deserialize<DeleteResponceModel>(actualResponce);
            if (expectedResult.status.Equals(actualResult.status) && expectedResult.message.Equals(actualResult.message))
            {
                return true;
            }
            return false;
        }
        public bool IsRecordStillInDataBase(string actualResponce)
        {
            var actualResult = JsonSerializer.Deserialize<EmployeeResponceModel>(actualResponce);
            if (actualResult.data != null)
            {
                return true;
            }
            return false;
        }
    }
}
