using APITest.Constants;
using EmployeeAPITest.Support.Models;

namespace EmployeeAPITest.Support.CreateExpectedResponce
{
    internal class WorkWithPutResponce
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
    }
}
