﻿using APITest.Constants;
using EmployeeAPITest.Support.Models;

namespace EmployeeAPITest.Support.WorkWithResponce
{
    public class WorkWithGetResponce
    {
        public static EmployeeResponceModel ExpectedResponceModelForSuccessfullGetByIdRequest(int userId)
        {
            var model = new EmployeeData();
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
                data = new EmployeeData
                {
                    employee_name = model.employee_name,
                    employee_salary = model.employee_salary,
                    employee_age = model.employee_age,
                    profile_image = model.profile_image
                },
                message = ResponceConstants.MessageGet
            };
            return expectedResponce;
        }
        public static EmployeeResponceModel ExpectedResponceModelForSuccessfullGetByIdRequest(List<EmployeeDataFromTable> employeeData, int userId)
        {
            EmployeeDataFromTable tempData = null;
            switch (userId)
            {
                case 1:
                    tempData = employeeData[0];
                    break;
                case 21:
                    tempData = employeeData[1];
                    break;
                case 12:
                    tempData = employeeData[2];
                    break;
            }
            var expectedResponce = new EmployeeResponceModel()
            {
                status = ResponceConstants.Status,
                data = new EmployeeData()
                {
                    employee_name = tempData.Name,
                    employee_salary = tempData.Salary,
                    employee_age = tempData.Age,
                    profile_image = null
                },
                message = ResponceConstants.MessageGet
            };
            return expectedResponce;
        }
    }
}
