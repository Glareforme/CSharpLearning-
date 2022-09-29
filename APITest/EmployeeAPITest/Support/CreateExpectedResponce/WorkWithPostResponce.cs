using APITest.Constants;
using EmployeeAPITest.Support.Models;
using System.Text.Json;

namespace EmployeeAPITest.Support.WorkWithResponce
{
    internal class WorkWithPostResponce
    {
        public EmployeeResponceModel ExpectedResponceModelForSuccessfullCreateIntDB()
        {
            var expectedResponce = new EmployeeResponceModel()
            {
                status = ResponceConstants.Status,
                data = new EmployeeData()
                {
                    employee_name = EmployeeCreateConst.name,
                    employee_salary = EmployeeCreateConst.salary,
                    employee_age = EmployeeCreateConst.age,
                },
                message = ResponceConstants.MessagePost
            };
            return expectedResponce;
        }
        public int GetIdJustCreatedEmployee(string responce)
        {
            var actualResponce = JsonSerializer.Deserialize<EmployeeResponceModel>(responce);
            return actualResponce.data.id;
        }
    }
}
