using DBTests.SetUpDB;
using NUnit.Framework;
using DBTests.DataForTest;
using DBTests.DataForTest.Constants;

namespace DBTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            DBController.CreateDB();
        }

        [Test]
        public void CheckIfCanAddDataToDatabase()
        {
            var createData = new CreateDataModels();
            var expectedResult = createData.CreateListWithFullMembers();

            DBController.AddDataToDB();
            var actualResult = DBController.GetDataFromDB();

            Assert.IsTrue(VerifyResponse.IsCreatedRecordsInDatabaseCorrect(expectedResult, actualResult));
        }

        [TestCase(ConstForTests.IdForDeleteEmployee)]
        public void CheckIfCanDeleteDataFromDataBase(int id)
        {
            var createData = new CreateDataModels();
            var expectedResult = createData.CreateUpdatedListWIthCompanyMembers();

            DBController.AddDataToDB();
            DBController.DeleteDataFromDB(id);
            var actualResult =  DBController.GetDataFromDB();

            Assert.IsTrue(VerifyResponse.IsCreatedRecordsInDatabaseCorrect(expectedResult, actualResult));
        }

        [TestCase(ConstForTests.IdForUpdateEmployee)]
        public void CheckIfCanUpdateDataInDatabase(int id)
        {
            var createData = new CreateDataModels();
            var expectedResult = createData.CreateUpdatedListWIthCompanyMembers();

            DBController.AddDataToDB();
            DBController.UpdateDataInDB(id);
            var actualResult = DBController.GetDataFromDB();

            Assert.IsTrue(VerifyResponse.IsCreatedRecordsInDatabaseCorrect(expectedResult, actualResult));
        }

        [Test]
        public void ChechIfCanGroupEmployeeInDatabaseByAge()
        {
            var createData = new CreateDataModels();
            var expectedData = createData.CreateGroupedByAgeListWithCompanyMembers();

            DBController.AddDataToDB();
            var actualData =  DBController.GroupDataByAgeInDB();

            Assert.IsTrue(VerifyResponse.IsCreatedRecordsInDatabaseCorrect(expectedData, actualData));
        }

        [TearDown]
        public void TearDown()
        {
          DBController.DeleteDB();
        }
    }
}