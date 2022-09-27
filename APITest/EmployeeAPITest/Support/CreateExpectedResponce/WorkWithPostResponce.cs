using APITest.Constants;
using EmployeeAPITest.Support.Models;

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
    }
}
