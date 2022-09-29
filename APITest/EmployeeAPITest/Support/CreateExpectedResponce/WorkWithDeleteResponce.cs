using APITest.Constants;
using EmployeeAPITest.Support.Models;

namespace EmployeeAPITest.Support.CreateExpectedResponce
{
    internal class WorkWithDeleteResponce
    {
        public static EmployeeResponceModel ExpectedResponceModelForSuccessfullDeleteByIdRequest()
        {
            EmployeeResponceModel actualResponce = new EmployeeResponceModel()
            {
                status = ResponceConstants.Status,
                data = null,
                message = ResponceConstants.MessageDelete
            };
            return actualResponce;
        }
    }
}
