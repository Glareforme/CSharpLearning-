using DBTests.DataForTest.Constants;
using DBTests.Models;

namespace DBTests.DataForTest
{
    internal class CreateDataModels
    {
        public List<Employees> CreateListWithFullMembers()
        {
            CreateDataModels createData = new CreateDataModels();
            var employees = createData.CreateListWIthCompanyMembers(1);
            return employees;
        }

        public List<Employees> CreateListWIthCompanyMembers()
        {
            var listOfEmployeeData = new List<Employees>();

            var firstEmployee = new Employees()
            {
                Name = ConstantsForCreateRecordInDB.NameFirstEmployee,
                Salary = ConstantsForCreateRecordInDB.SalaryFirstEmployee,
                Age = ConstantsForCreateRecordInDB.AgeFirstEmployee,
                ProfileImage = ConstantsForCreateRecordInDB.ProfImageFirstEmployee
            };
            var secondEmployee = new Employees()
            {
                Name = ConstantsForCreateRecordInDB.NameSecondEmployee,
                Salary = ConstantsForCreateRecordInDB.SalarySecondEmployee,
                Age = ConstantsForCreateRecordInDB.AgeSecondEmployee,
                ProfileImage = ConstantsForCreateRecordInDB.ProfImageSecondEmpolyee
            };
            var thirdEmployee = new Employees()
            {
                Name = ConstantsForCreateRecordInDB.NameThirdEmployee,
                Salary = ConstantsForCreateRecordInDB.SalaryThirdEmployee,
                Age = ConstantsForCreateRecordInDB.AgeThirdEmployee,
                ProfileImage = ConstantsForCreateRecordInDB.ProfImageThirdEmployee
            };

            listOfEmployeeData.Add(firstEmployee);
            listOfEmployeeData.Add(secondEmployee);
            listOfEmployeeData.Add(thirdEmployee);


            return listOfEmployeeData;
        }

        private List<Employees> CreateListWIthCompanyMembers(int forTests)
        {
            var listOfEmployeeData = new List<Employees>();

            var firstEmployee = new Employees()
            {
                Id = ConstantsForCreateRecordInDB.IdFirstEmployee,
                Name = ConstantsForCreateRecordInDB.NameFirstEmployee,
                Salary = ConstantsForCreateRecordInDB.SalaryFirstEmployee,
                Age = ConstantsForCreateRecordInDB.AgeFirstEmployee,
                ProfileImage = ConstantsForCreateRecordInDB.ProfImageFirstEmployee
            };
            var secondEmployee = new Employees()
            {
                Id = ConstantsForCreateRecordInDB.IdSecondEmployee,
                Name = ConstantsForCreateRecordInDB.NameSecondEmployee,
                Salary = ConstantsForCreateRecordInDB.SalarySecondEmployee,
                Age = ConstantsForCreateRecordInDB.AgeSecondEmployee,
                ProfileImage = ConstantsForCreateRecordInDB.ProfImageSecondEmpolyee
            };
            var thirdEmployee = new Employees()
            {
                Id = ConstantsForCreateRecordInDB.IdThirdEmployee,
                Name = ConstantsForCreateRecordInDB.NameThirdEmployee,
                Salary = ConstantsForCreateRecordInDB.SalaryThirdEmployee,
                Age = ConstantsForCreateRecordInDB.AgeThirdEmployee,
                ProfileImage = ConstantsForCreateRecordInDB.ProfImageThirdEmployee
            };

            listOfEmployeeData.Add(firstEmployee);
            listOfEmployeeData.Add(secondEmployee);
            listOfEmployeeData.Add(thirdEmployee);


            return listOfEmployeeData;
        }

        public List<Employees> CreateUpdatedListWIthCompanyMembers()
        {
            var listOfEmployeeData = new List<Employees>();

            var firstEmployee = new Employees()
            {
                Name = ConstantsForCreateRecordInDB.NameFirstEmployee,
                Salary = ConstantsForCreateRecordInDB.SalaryFirstEmployee,
                Age = ConstantsForCreateRecordInDB.AgeFirstEmployee,
                ProfileImage = ConstantsForCreateRecordInDB.ProfImageFirstEmployee
            };
            var secondEmployee = new Employees()
            {
                Name = ConstantsForUpdateRecordInDB.NameUpdateEmployee,
                Salary = ConstantsForUpdateRecordInDB.SalaryUpdeteEmployee,
                Age = ConstantsForUpdateRecordInDB.AgeUpdateEmployee,
                ProfileImage = ConstantsForCreateRecordInDB.ProfImageSecondEmpolyee
            };
            var thirdEmployee = new Employees()
            {
                Name = ConstantsForCreateRecordInDB.NameThirdEmployee,
                Salary = ConstantsForCreateRecordInDB.SalaryThirdEmployee,
                Age = ConstantsForCreateRecordInDB.AgeThirdEmployee,
                ProfileImage = ConstantsForCreateRecordInDB.ProfImageThirdEmployee
            };

            listOfEmployeeData.Add(firstEmployee);
            listOfEmployeeData.Add(secondEmployee);
            listOfEmployeeData.Add(thirdEmployee);

            return listOfEmployeeData;
        }

        public List<Employees> CreateDeletedListWithCompanyMembers()
        {
            var listOfEmployeeData = new List<Employees>();

            var firstEmployee = new Employees()
            {
                Name = ConstantsForCreateRecordInDB.NameSecondEmployee,
                Salary = ConstantsForCreateRecordInDB.SalarySecondEmployee,
                Age = ConstantsForCreateRecordInDB.AgeSecondEmployee,
                ProfileImage = ConstantsForCreateRecordInDB.ProfImageSecondEmpolyee
            };
            var secondEmployee = new Employees()
            {
                Name = ConstantsForCreateRecordInDB.NameThirdEmployee,
                Salary = ConstantsForCreateRecordInDB.SalaryThirdEmployee,
                Age = ConstantsForCreateRecordInDB.AgeThirdEmployee,
                ProfileImage = ConstantsForCreateRecordInDB.ProfImageThirdEmployee
            };

            listOfEmployeeData.Add(firstEmployee);
            listOfEmployeeData.Add(secondEmployee);

            return listOfEmployeeData;
        }

        public List<Employees> CreateGroupedByAgeListWithCompanyMembers()
        {
            var listOfEmployeeData = new List<Employees>();

            var firstEmployee = new Employees()
            {
                Name = ConstantsForCreateRecordInDB.NameSecondEmployee,
                Salary = ConstantsForCreateRecordInDB.SalarySecondEmployee,
                Age = ConstantsForCreateRecordInDB.AgeSecondEmployee,
                ProfileImage = ConstantsForCreateRecordInDB.ProfImageSecondEmpolyee
            };
            var secondEmployee = new Employees()
            {
                Name = ConstantsForCreateRecordInDB.NameThirdEmployee,
                Salary = ConstantsForCreateRecordInDB.SalaryThirdEmployee,
                Age = ConstantsForCreateRecordInDB.AgeThirdEmployee,
                ProfileImage = ConstantsForCreateRecordInDB.ProfImageThirdEmployee
            };
            var thirdEmployee = new Employees()
            {
                Name = ConstantsForCreateRecordInDB.NameFirstEmployee,
                Salary = ConstantsForCreateRecordInDB.SalaryFirstEmployee,
                Age = ConstantsForCreateRecordInDB.AgeFirstEmployee,
                ProfileImage = ConstantsForCreateRecordInDB.ProfImageFirstEmployee
            };
            listOfEmployeeData.Add(firstEmployee);
            listOfEmployeeData.Add(secondEmployee);
            listOfEmployeeData.Add(thirdEmployee);
            return listOfEmployeeData;
        }
    }
}
