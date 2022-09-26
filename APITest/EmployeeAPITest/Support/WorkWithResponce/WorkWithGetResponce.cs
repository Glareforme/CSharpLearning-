using EmployeeAPITest.Drivers;
using System.Text.Json;
using APITest.Constants;
using EmployeeAPITest.Support.Models;

namespace EmployeeAPITest.Support.WorkWithResponce
{
    public class WorkWithResponce : EmployeeRequestController
    {
        public EmployeeResponceModel ExpectedResultModelForSuccessFullGetByIdRequest(int userId)
        {
            EmployeeData model = new EmployeeData();
            switch (userId)
            {
                case (1):
                    model = new ExpFirstEmpolee();
                    break;
                case (21):
                    model = new ExpSecondEmployee();
                    break;
                case (12):
                    model = new ExpThirdEmployee();
                    break;
            }
            var expectedResponce = new EmployeeResponceModel()
            {
                status = ResponceConstants.Status,
                data = model,
                message = ResponceConstants.MessageGet
            };
            return expectedResponce;
        }
    }
}
