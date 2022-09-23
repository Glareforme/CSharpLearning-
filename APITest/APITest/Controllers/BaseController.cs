using APITest.Constants;
using APITest.Managers;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APITest.Controllers
{
    public class BaseController : ConfigManager
    {
        Dictionary<string, string> _responceData;
        protected string BaseUrl => Config[ConfigConstants.BaseUrl];
        protected RestClient RestClient => new RestClient(this.BaseUrl);
        private const string _responceStatusCode = "statusCode";
        private const string _responceBody = "responceBody";
        private async Task<string> GetResponceAsync(string resource)
        {
            var request = new RestRequest(resource, Method.GET);
            var responce = await this.RestClient.ExecuteAsync(request);
            return responce.Content.ToString();
        }
        protected async Task<string> GetAsync(string resource)
        {
            var request = new RestRequest(resource, Method.GET);
            var responce = await this.RestClient.ExecuteAsync(request);
            return responce.Content.ToString();
        }
        protected async Task<string> PostAsync(string resource, object body)
        {
            var request = new RestRequest(resource, Method.POST);
            request.AddJsonBody(body);
            var responce = await this.RestClient.ExecuteAsync(request);
            return responce.Content.ToString();
        }
        protected async Task<string> PutAsync(string resource, object body)
        {
            var request = new RestRequest(resource, Method.PUT);
            request.AddJsonBody(body);
            var response = await this.RestClient.ExecuteAsync(request);
            return response.Content.ToString();
        }
        protected async Task<string> DeleteAsync(string resource)
        {
            var request = new RestRequest(resource, Method.DELETE);
            var responce = await this.RestClient.ExecuteAsync(request);
            return responce.Content.ToString();
        }
    }
}
