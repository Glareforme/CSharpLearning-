using APITest.Controllers;
using FluentAssertions;
using NUnit.Framework;
using System.Threading.Tasks;
using APITest.Constants;
using System.Text.Json;
using APITest.Models;

namespace APITest.Tests
{
    [TestFixture]
    public class EmployeeTest : EmployeeController
    {

        [Test]
        public async Task CheckThatEmployeeControllerReturnsResponse()
        {
            var response = await this.GetEmployeeAsync();
            response.Should().NotBeNull("Response is null");
        }

        [TestCase(RequestID.FirstSearchId)]
        [TestCase(RequestID.SecondSearchId)]
        public async Task CheckThanEmployeeControllerReturnCorrectDataResponce(int id)
        {
            var responce = await this.GetEmployeeByIdAsync(id);
            var expResponce = new ResponceModel
            {
                status = ResponceConstants.Status,
                data = new EmployeeModel
                {
                    Id = id == 1 ? ExpFirstEmployee.Id : ExpSecondEmployee.Id,
                    Name = id == 1 ? ExpFirstEmployee.Name : ExpSecondEmployee.Name,
                    Salary = id == 1 ? ExpFirstEmployee.Salary : ExpSecondEmployee.Salary,
                    Age = id == 1 ? ExpFirstEmployee.Age : ExpSecondEmployee.Age,
                    ProfilePic = id == 1 ? ExpFirstEmployee.ProfilePic : ExpSecondEmployee.ProfilePic
                },
                message = ResponceConstants.MessageGet
            };
            var actualResponce = JsonSerializer.Deserialize<ResponceModel>(responce);
            Assert.AreEqual(expResponce.status, actualResponce.status);
            Assert.IsTrue(AssertForModel.IsResponceEquals(actualResponce, expResponce));
            Assert.AreEqual(expResponce.message, actualResponce.message);
        }
        [Test]
        public async Task CheckIfYouCanCreateNewRecordInBase()
        {

            var responce = await this.PostCreateEmployeeAsync();
            var expectedRes = new ResponceModel
            {
                status = ResponceConstants.Status,
                data = new EmployeeModel
                {
                    Name = EmployeeCreateConst.name,
                    Salary = EmployeeCreateConst.salary,
                    Age = EmployeeCreateConst.age
                },
                message = ResponceConstants.MessagePost
            };
            var actualRes = JsonSerializer.Deserialize<ResponceModel>(responce);
            Assert.AreEqual(expectedRes.status, actualRes.status);
            Assert.IsTrue(AssertForModel.IsResponceEquals(expectedRes, actualRes));
            Assert.AreEqual(expectedRes.message, actualRes.message);
        }
        [TestCase(RequestID.FirstSearchId)]
        public async Task CheckIfYouCanUpdateExistingRecondInBase(int id)
        {
            var responce = await this.PutUpdateEmpoyeeById(id);

            var expResponce = new ResponceModel
            {
                status = ResponceConstants.Status,
                data = new EmployeeModel
                {
                   Name= EmployeeUpdateConst.name,
                   Salary= EmployeeUpdateConst.salary,
                   Age= EmployeeUpdateConst.age
                },
                message = ResponceConstants.MessagePut
            };
            var actualResponce = JsonSerializer.Deserialize<ResponceModel>(responce);
            Assert.AreEqual(expResponce.status, actualResponce.status);
            Assert.IsTrue(AssertForModel.IsResponceEquals(actualResponce, expResponce));
            Assert.AreEqual(expResponce.message, actualResponce.message);
        }
        [TestCase(RequestID.FirstSearchId)]
        public async Task CheckIfYouCanDeleteExistingRecondFromBase(int id)
        {
            var responce = await this.DeleteEmployeeById(id);

            var expectedResponce = new ResponceDeleteMeth
            {
                status = ResponceConstants.Status,
                data = id.ToString(),
                message = ResponceConstants.MessageDelete
            };
            var actualResponce = JsonSerializer.Deserialize<ResponceDeleteMeth>(responce);
            Assert.AreEqual(expectedResponce.status, actualResponce.status);
            Assert.AreEqual(expectedResponce.data, actualResponce.data);
            Assert.AreEqual(expectedResponce.message, actualResponce.message);

        }
        [TestCase(RequestID.FirstIncorrectFormatId)]
        public async Task CheckIfIdIncorrectFormatReturn400StatusWithGet(int id)
        {
            var responce = await this.GetEmployeeByIdAsync(id);
            var expResponce = new ErrorResponceModel
            {
                status = ResponceConstants.ErrorStatus,
                message = ResponceConstants.ErrorMassageNotFound,
                code = ResponceConstants.Status400,
                errors = ResponceConstants.ErrorContentIdEmpty
            };
            var actualResponce = JsonSerializer.Deserialize<ErrorResponceModel>(responce);
            Assert.AreEqual(expResponce.status, actualResponce.status);
            Assert.AreEqual(expResponce.message, actualResponce.message);
            Assert.AreEqual(expResponce.code, actualResponce.code);
            Assert.AreEqual(expResponce.errors, actualResponce.errors);
        }
        [Test]
        public async Task CheckIfYouCantGetDataFromJustCreateRecord()
        {
            var expectedResponce = new ResponceModel
            {
                status = ResponceConstants.Status,
                data = null,
                message = ResponceConstants.MessageGet
            };
            var createEmployeeInBase = await this.PostCreateEmployeeAsync();
            var postResponce = JsonSerializer.Deserialize<ResponceModel>(createEmployeeInBase);
            var getDataFrom = await this.GetEmployeeByIdAsync(postResponce.data.id);
            var actualResponce = JsonSerializer.Deserialize<ResponceModel>(getDataFrom);
            Assert.AreEqual(expectedResponce.status, actualResponce.status);
            Assert.AreEqual(expectedResponce.data, actualResponce.data);
            Assert.AreEqual(expectedResponce.message, actualResponce.message);
        }
    }
}
