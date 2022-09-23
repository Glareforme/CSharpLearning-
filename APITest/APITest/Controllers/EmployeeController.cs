using RestSharp;
using System.Text.Json;
using System.Threading.Tasks;
using APITest.Models;
using System.Collections.Generic;
using APITest.Constants;

namespace APITest.Controllers
{
    public class EmployeeController : BaseController
    {
        private const string GetEmployeeUrl = "/employees";
        private const string GetEmployeeByIdUrl = "/employee/{0}";
        private const string PostCreateEmployeeUrl = "/create";
        private const string PutUpdateEmployeeByIdUrl = "update/{0}";
        private const string DeleteEmployeeUrl = "/delete/{0}";

        protected async Task<string> GetEmployeeAsync()
        {
            var resource = string.Join(this.BaseUrl, GetEmployeeUrl);
            return await this.GetAsync(resource);
        }

        protected async Task<string> GetEmployeeByIdAsync(int employeeId)
        {
            var resource = string.Join(this.BaseUrl, string.Format(GetEmployeeByIdUrl, employeeId));
            return await this.GetAsync(resource);
        }
        protected async Task<string> PostCreateEmployeeAsync()
        {
            var dataForBody = new EmployeeModel()
            {
                Name = EmployeeCreateConst.name,
                Salary = EmployeeCreateConst.salary,
                Age = EmployeeCreateConst.age
            };
            var resource = string.Join(this.BaseUrl, PostCreateEmployeeUrl);
            var body = JsonSerializer.Serialize(dataForBody);
            return await this.PostAsync(resource, body);
        }
        protected async Task<string> PutUpdateEmpoyeeById(int employeeId)
        {
            var resource = string.Join(this.BaseUrl, string.Format(PutUpdateEmployeeByIdUrl, employeeId));
            var dataForBody = new EmployeeModel()
            {
                Name= EmployeeUpdateConst.name,
                Salary= EmployeeUpdateConst.salary,
                Age= EmployeeUpdateConst.age
            };
            var body = JsonSerializer.Serialize(dataForBody);
            return await this.PutAsync(resource, body);
        }
        protected async Task<string> DeleteEmployeeById(int employeeId)
        {
            var resource = string.Join(this.BaseUrl, string.Format(DeleteEmployeeUrl, employeeId));
            return await this.DeleteAsync(resource);
        }
    }
}
