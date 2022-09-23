using APITest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace APITest.Controllers
{
    internal class AssertForModel
    {
        public static bool IsResponceEquals(ResponceModel actualResponce, ResponceModel expectedResponce)
        {
            if (expectedResponce.data.Name.Equals(actualResponce.data.Name))
            {
                if (expectedResponce.data.Salary.Equals(actualResponce.data.Salary))
                {
                    if (expectedResponce.data.Age.Equals(actualResponce.data.Age))
                    {
                        return true;
                    }
                }    
            }
            return false;
        }
    }
}
