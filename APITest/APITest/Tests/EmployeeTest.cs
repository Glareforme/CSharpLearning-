using APITest.Controllers;
using FluentAssertions;
using NUnit.Framework;
using System.Threading.Tasks;

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
        [Test]
        public async Task CheckThanEmployeeControllerReturnCorrectDataResponce()
        {
        }
        [Test]
        public async Task CheckIfYouCanCreateNewRecordInBase()
        {
        }
        [Test]
        public async Task CheckIfYouCanUpdateExistingRecondInBase()
        {

        }
        [Test]
        public async Task CheckIfYouCanDeleteExistingRecondFromBase()
        {

        }
        [Test]
        public async Task CheckIfIdIncorrectFormatReturn400Status()
        {

        }
        [Test]
        public async Task CheckIfEnterDataInIncorrectFormatReturn400status()
        {

        }
    }
}
