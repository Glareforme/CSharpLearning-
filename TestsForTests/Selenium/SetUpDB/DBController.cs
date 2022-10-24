using DBTests.Models;
using DBTests.DataForTest;
using DBTests.DataForTest.Constants;

namespace DBTests.SetUpDB
{
    internal static class DBController
    {
        public static void CreateDB()
        {
            using (var dBConect = new DBConectController())
            {
                dBConect.Database.EnsureDeleted();
                dBConect.Database.EnsureCreated();
            }
        }

        public static void AddDataToDB()
        {
            using (var dBConect = new DBConectController())
            {
                CreateDataModels createData = new CreateDataModels();
                var members = createData.CreateListWIthCompanyMembers();
                foreach (var employee in members)
                {
                    dBConect.Employees.Add(employee);
                }
                dBConect.SaveChanges();
            }
        }

        public static void UpdateDataInDB(int employeeId)
        {
            using (var dbConnect = new DBConectController())
            {
                var employeeForUpdate = dbConnect.Employees.FirstOrDefault(x => x.Id == employeeId);
                if (employeeForUpdate != null)
                {
                    employeeForUpdate.Name = ConstantsForUpdateRecordInDB.NameUpdateEmployee;
                    employeeForUpdate.Salary = ConstantsForUpdateRecordInDB.SalaryUpdeteEmployee;
                    employeeForUpdate.Age = ConstantsForUpdateRecordInDB.AgeUpdateEmployee;
                }
                dbConnect.SaveChanges();
            }
        }

        public static void DeleteDataFromDB(int employeeId)
        {
            using (var dbConnect = new DBConectController())
            {
                var employeeForDelete = dbConnect.Employees.FirstOrDefault(x => x.Id == employeeId);
                if (employeeForDelete != null)
                {
                    dbConnect.Employees.Remove(employeeForDelete);
                    dbConnect.SaveChanges();
                }
            }
        }

        public static List<Employees> GetDataFromDB()
        {
            using (var dbConect = new DBConectController())
            {
                var listOfEmployee = dbConect.Employees.ToList();
                return listOfEmployee;
            }
        }

        public static List<Employees> GroupDataByAgeInDB()
        {
            using (var dbConnect = new DBConectController())
            {
                var listOfEmployees = dbConnect.Employees.ToList();
                var sortedList = listOfEmployees.OrderBy(x => x.Age).ToList();
                return sortedList;
            }
        }

        public static void DeleteDB()
        {
            using (DBConectController dBController = new DBConectController())
            {
                dBController.Database.EnsureDeleted();
            }
        }
    }
}
