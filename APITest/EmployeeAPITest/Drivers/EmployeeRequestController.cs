using EmployeeAPITest.Support.Models;
using APITest.Constants;
using APITest.Models;
using EmployeeAPITest.Drivers;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace EmployeeAPITest.Drivers
{
    public class EmployeeRequestController : BaseController
    {
        private const string GetEmployeeUrl = "/employees";
        private const string GetEmployeeByIdUrl = "/employee/{0}";
        private const string PostCreateEmployeeUrl = "/create";
        private const string PutUpdateEmployeeByIdUrl = "/update/{0}";
        private const string DeleteEmployeeUrl = "/delete/{0}";

        protected async Task<string> GetEmployeeByIdAsync(int employeeId)
        {
            var resource = string.Format(GetEmployeeByIdUrl, employeeId);
            return await this.GetAsync(resource);
        }

        protected async Task<string> PostCreateEmployeeRecord() 
        {
            var employeeModel = new EmployeeModel
            {
                Name = EmployeeCreateConst.name,
                Salary = EmployeeCreateConst.salary,
                Age = EmployeeCreateConst.age
            };
            var requestBody = JsonSerializer.Serialize(employeeModel);
            return await this.PostAsync(PostCreateEmployeeUrl, requestBody);
        }
        protected async Task<string> PostCreateEmployeeRecordIncorrectFormat()
        {
            var employeeModel = new EmployeeModel
            {
                Name = EmployeeCreateConst.name,
                Salary = EmployeeCreateConst.incorrectSalary,
                Age = EmployeeCreateConst.age
            };
            var requestBody = JsonSerializer.Serialize(employeeModel);
            return await this.PostAsync(PostCreateEmployeeUrl, requestBody);
        }
        protected async Task<string> PutUpdateEmployeeRecord(int employeeId)
        {
            var resource = string.Format(PutUpdateEmployeeByIdUrl, employeeId);
            var employeeModel = new EmployeeModel
            {
                Name = EmployeeUpdateConst.name,
                Salary = EmployeeUpdateConst.salary,
                Age = EmployeeUpdateConst.age
            };
            var requestBody = JsonSerializer.Serialize(employeeModel);
            return await this.PutAsync(resource, requestBody);
        }

        protected async Task<string> DeleteRecordFromDatabase(int employeeId)
        {
            var resource = string.Format(DeleteEmployeeUrl, employeeId);
            return await this.DeleteAsync(resource);
        }
    }
}
