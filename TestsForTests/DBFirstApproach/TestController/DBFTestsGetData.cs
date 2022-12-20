using NUnit.Framework;
using DBFirstApproach.GetDataInDB;

namespace DBFirstApproach
{
    internal class DBFTestsGetData
    {
        [Test]
        public void CheckIfCanTakeContactNamesFromCustomersTable()
        {
            var actualResult = GetDataFromCustomerTable.GetContactNameFromCustomerTable();
            Assert.IsNotNull(actualResult);
        }

        [Test]
        public void CheckIfDataBaseReturnedCorrectCompanyNamesFromCustomersTable()
        {

        }

        [Test]
        public void CheckIfContactNameAndCompanyNameCorresponded()
        {

        }
    }
}
