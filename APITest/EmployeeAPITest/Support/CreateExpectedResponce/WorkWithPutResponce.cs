using APITest.Constants;
using EmployeeAPITest.Support.Models;

namespace EmployeeAPITest.Support.CreateExpectedResponce
{
    public class WorkWithPutResponce
    {
        public EmployeeResponceModel EmployeeResponceModelForSuccessfullPutRequestById()
        {
            var employeeResponce = new EmployeeResponceModel()
            {
                status = ResponceConstants.Status,
                data = new EmployeeData
                {
                    employee_name = EmployeeUpdateConst.name,
                    employee_age = EmployeeUpdateConst.age,
                    employee_salary = EmployeeUpdateConst.salary
                },
                message = ResponceConstants.MessagePut
            };
            return employeeResponce;
        }
        public static EmployeeResponceModel EmployeeResponceModelForSuccessfullPutRequestById(EmployeeDataFromTable dataFromTable)
        {
            var employeeResponce = new EmployeeResponceModel()
            {
                status = ResponceConstants.Status,
                data = new EmployeeData
                {
                    employee_name = dataFromTable.Name,
                    employee_age = dataFromTable.Age,
                    employee_salary = dataFromTable.Salary
                },
                message = ResponceConstants.MessagePut
            };
            return employeeResponce;
        }
    }
}
