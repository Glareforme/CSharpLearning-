using EmployeeAPITest.Support.Models;
using APITest.Constants;
using APITest.Models;
using EmployeeAPITest.Drivers;

namespace EmployeeAPITest.Drivers
{
    public class EmployeeRequestController : BaseController
    {
        private const string GetEmployeeUrl = "/employees";
        private const string GetEmployeeByIdUrl = "/employee/{0}";
        private const string PostCreateEmployeeUrl = "/create";
        private const string PutUpdateEmployeeByIdUrl = "update/{0}";
        private const string DeleteEmployeeUrl = "/delete/{0}";

        protected async Task<string> GetEmployeeByIdAsync(int employeeId)
        {
            var resource = string.Format(GetEmployeeByIdUrl, employeeId);
            return await this.GetAsync(resource);
        }

        protected async Task<string> PostCreateEmployeeRecord() 
        {
            var requestBody = new EmployeeModel
            {
                Name = EmployeeCreateConst.name,
                Salary = EmployeeCreateConst.salary,
                Age = EmployeeCreateConst.age
            };
            return await this.PostAsync(PostCreateEmployeeUrl, requestBody);
        }

        protected async Task<string> PutUpdateEmployeeRecord(int employeeId)
        {
            var resource = string.Format(PutUpdateEmployeeByIdUrl, employeeId);
            var requestBody = new EmployeeModel
            {
                Name = EmployeeUpdateConst.name,
                Salary = EmployeeUpdateConst.salary,
                Age = EmployeeUpdateConst.age
            };
            return await this.PostAsync(resource, requestBody);
        }

        protected async Task<string> DeleterecordFromDatabase(int employeeId)
        {
            var resource = string.Format(PutUpdateEmployeeByIdUrl, employeeId);
            return await this.DeleteAsync(resource);
        }
    }
}
