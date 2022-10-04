using APITest.Constants;
using EmployeeAPITest.Support.Models;
using System.Text.Json;

namespace EmployeeAPITest.Support.WorkWithResponce
{
    internal class WorkWithPostResponce
    {
        public static EmployeeResponceModel ExpectedResponceModelForSuccessfullCreateIntDB()
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
        public static EmployeeResponceModel ExpectedResponceModelForSuccessfullCreateIntDB(EmployeeDataFromTable dataFromTable)
        {
            var expectedResponce = new EmployeeResponceModel()
            {
                status = ResponceConstants.Status,
                data = new EmployeeData()
                {
                    employee_name = dataFromTable.Name,
                    employee_salary = dataFromTable.Salary,
                    employee_age = dataFromTable.Age
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
