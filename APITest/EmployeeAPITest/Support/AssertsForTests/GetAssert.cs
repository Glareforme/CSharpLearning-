﻿using EmployeeAPITest.Support.Models;
using EmployeeAPITest.Support.WorkWithResponce;
using System.Text.Json;

namespace EmployeeAPITest.Support.AssertsForTests
{
    internal class GetAssert
    {
        public bool IsGetRecordByIdCorrectResponce(int userId, string actualResponce)
        {
            var expectedResult = WorkWithGetResponce.ExpectedResponceModelForSuccessfullGetByIdRequest(userId);
            var actualResult = JsonSerializer.Deserialize<EmployeeResponceModel>(actualResponce);
            if (expectedResult.status.Equals(actualResult.status) && expectedResult.message.Equals(actualResult.message))
            {
              return true;
            }
            return false;
        }
    }
}
