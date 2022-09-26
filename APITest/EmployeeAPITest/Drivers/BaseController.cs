﻿using APITest.Constants;
using APITest.Managers;

namespace EmployeeAPITest.Drivers
{
    public class BaseController : ConfigManager
    {
        protected string BaseUrl => Config[ConfigConstants.BaseUrl];

        protected HttpClient Client => new HttpClient();

        protected async Task<string> GetAsync(string endpoint)
        {
            var responce = await Client.GetAsync(BaseUrl + endpoint);
            return await responce.Content.ReadAsStringAsync();
        }

        protected async Task<string> PostAsync(string endpoint, object body)
        {
            var responce = await Client.PostAsync(BaseUrl + endpoint, (HttpContent?)body);
            return await responce.Content.ReadAsStringAsync();
        }
        protected async Task<string> PutAsync(string endpoint, object body)
        {
            var responce = await Client.PutAsync(BaseUrl + endpoint, (HttpContent?)body);
            return await responce.Content.ReadAsStringAsync();
        }
        protected async Task<string> DeleteAsync(string endpoint)
        {
            var responce = await Client.DeleteAsync(BaseUrl + endpoint);
            return await responce.Content.ReadAsStringAsync();
        }
    }
}
