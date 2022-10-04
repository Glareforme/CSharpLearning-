using APITest.Constants;
using APITest.Managers;

namespace EmployeeAPITest.Drivers
{
    public class BaseController
    {
        ConfigManager config = new ConfigManager();
        protected string BaseUrl => config.Config[ConfigConstants.BaseUrl];

        protected HttpClient Client => new HttpClient();

        protected async Task<string> GetAsync(string endpoint)
        {
            var responce = await Client.GetAsync(BaseUrl + endpoint);
            return await responce.Content.ReadAsStringAsync();
        }

        protected async Task<string> PostAsync(string endpoint, string body)
        {
            var requestBody = new StringContent(body);
            var responce = await Client.PostAsync(BaseUrl + endpoint, requestBody);
            return await responce.Content.ReadAsStringAsync();
        }
        protected async Task<string> PutAsync(string endpoint, string body)
        {
            var requestBody = new StringContent(body);
            var responce = await Client.PutAsync(BaseUrl + endpoint, requestBody);
            return await responce.Content.ReadAsStringAsync();
        }
        protected async Task<string> DeleteAsync(string endpoint)
        {
            var responce = await Client.DeleteAsync(BaseUrl + endpoint);
            return await responce.Content.ReadAsStringAsync();
        }
    }
}
