using RestSharp;
using System.Threading.Tasks;

namespace APITest.Controllers
{
    public class EmployeeController : BaseController
    {
        private const string GetEmployeeUrl = "/employees";
        private const string GetEmployeeByIdUrl = "/employees/{0}";
        private const string PostCreateEmployeeUrl = "/create";
        private const string PutUpdateEmployeeByIdUrl = "update/{0}";
        private const string DeleteEmployeeUrl = "/delete/{0}";

        protected async Task<object> GetEmployeeAsync()
        {
            var resource = string.Join(this.BaseUrl, GetEmployeeUrl);
            return await this.GetAsync(resource);
        }

        protected async Task<object> GetEmployeeByIdAsync(int employeeId)
        {
            var resource = string.Join(this.BaseUrl, string.Format(GetEmployeeByIdUrl, employeeId));
            return await this.GetAsync(resource);
        }
        protected async Task<object> PostCreateEmployeeAsync(object body)
        {
            var resource = string.Join(this.BaseUrl, PostCreateEmployeeUrl);
            return await this.PostAsync(resource, body);
        }
        protected async Task<object> PutUpdateEmpoyeeById(object body)
        {
            var resource = string.Join(this.BaseUrl, PutUpdateEmployeeByIdUrl);
            return await this.PutAsync(resource, body);
        }
    }
}
