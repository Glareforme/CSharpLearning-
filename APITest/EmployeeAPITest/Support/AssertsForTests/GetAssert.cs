using EmployeeAPITest.Support.Models;
using EmployeeAPITest.Support.WorkWithResponce;
using System.Text.Json;

namespace EmployeeAPITest.Support.AssertsForTests
{
    internal class GetAssert
    {
        WorkWithResponce.WorkWithResponce workWithResponce = new WorkWithResponce.WorkWithResponce();
        public bool IsExpectedAndActualResponcesame(int userId, string actualResponce)
        {
            var expectedResult = workWithResponce.ExpectedResultModelForSuccessFullGetByIdRequest(userId);
            var actualResunt = JsonSerializer.Deserialize<EmployeeResponceModel>(actualResponce);
            if (expectedResult.status.Equals(actualResunt.status))
            {
                if(expectedResult.data.employee_name.Equals(actualResunt.data.employee_name) && expectedResult.data.employee_salary.Equals(actualResunt.data.employee_salary))
                {
                    return true;
                }    
            }
                return false;
        }
    }
}
