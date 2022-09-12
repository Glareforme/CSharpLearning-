using APITest.Constants;
using APITest.Managers;
using RestSharp;
using System.Threading.Tasks;

namespace APITest.Controllers
{
    public class BaseController : ConfigManager
    {
        protected string BaseUrl => Config[ConfigConstants.BaseUrl];
        protected RestClient RestClient => new RestClient(this.BaseUrl);

        protected async Task<object> GetAsync(string resource)
        {
            var request = new RestRequest(resource, Method.GET);
            return await this.RestClient.GetAsync<object>(request);
        }
        protected async Task<object> PostAsync(string resource, object body)
        {
            var request = new RestRequest(resource, Method.POST);
            request.AddJsonBody(body);
            return await this.RestClient.PostAsync<object>(request);
        }
        protected async Task<object> PutAsync(string resource, object body)
        {
            var request = new RestRequest(resource, Method.PUT);
            request.AddBody(body);
            return await this.RestClient.PutAsync<object>(request);
        }
        protected async Task<object> DeleteAsync(string resource, object body)
        {
            var request = new RestRequest(resource, Method.DELETE);
            request.AddJsonBody(body);
            return await this.RestClient.DeleteAsync<object>(request);
        }
    }
}
