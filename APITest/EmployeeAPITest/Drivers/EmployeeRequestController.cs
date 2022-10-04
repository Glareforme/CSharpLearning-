using APITest.Constants;
using APITest.Models;
using System.Text.Json;
using EmployeeAPITest.Support.Constants;

namespace EmployeeAPITest.Drivers
{
    public class EmployeeRequestController : BaseController
    {
        public async Task<string> GetEmployeeByIdAsync(int employeeId)
        {
            var resource = string.Format(EndpointsForRequest.GetEmployeeByIdUrl, employeeId);
            return await this.GetAsync(resource);
        }

        public async Task<string> PostCreateEmployeeRecord() 
        {
            var employeeModel = new EmployeeModel
            {
                Name = EmployeeCreateConst.name,
                Salary = EmployeeCreateConst.salary,
                Age = EmployeeCreateConst.age
            };
            var requestBody = JsonSerializer.Serialize(employeeModel);
            return await this.PostAsync(EndpointsForRequest.PostCreateEmployeeUrl, requestBody);
        }

        public async Task<string> PostCreateEmployeeRecordIncorrectFormat()
        {
            var employeeModel = new EmployeeModel
            {
                Name = EmployeeCreateConst.name,
                Salary = EmployeeCreateConst.incorrectSalary,
                Age = EmployeeCreateConst.age
            };
            var requestBody = JsonSerializer.Serialize(employeeModel);
            return await this.PostAsync(EndpointsForRequest.PostCreateEmployeeUrl, requestBody);
        }

        public async Task<string> PutUpdateEmployeeRecord(int employeeId)
        {
            var resource = string.Format(EndpointsForRequest.PutUpdateEmployeeByIdUrl, employeeId);
            var employeeModel = new EmployeeModel
            {
                Name = EmployeeUpdateConst.name,
                Salary = EmployeeUpdateConst.salary,
                Age = EmployeeUpdateConst.age
            };
            var requestBody = JsonSerializer.Serialize(employeeModel);
            return await this.PutAsync(resource, requestBody);
        }

        public async Task<string> DeleteRecordFromDatabase(int employeeId)
        {
            var resource = string.Format(EndpointsForRequest.DeleteEmployeeUrl, employeeId);
            return await this.DeleteAsync(resource);
        }
    }
}
