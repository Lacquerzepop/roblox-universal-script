using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace RobloxUniversalScript
{
    public class RobloxUniversalScript
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;

        public RobloxUniversalScript(string baseUrl = "https://api.roblox.com")
        {
            _httpClient = new HttpClient();
            _baseUrl = baseUrl;
        }

        public async Task<string> ExecuteScriptAsync(string scriptContent, string userId = "")
        {
            var parameters = new Dictionary<string, string>
            {
                { "script", scriptContent },
                { "userId", string.IsNullOrEmpty(userId) ? "0" : userId }
            };

            var content = new FormUrlEncodedContent(parameters);
            var response = await _httpClient.PostAsync($"{_baseUrl}/universal-script/v1/execute", content);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetScriptResultAsync(string scriptId)
        {
            var response = await _httpClient.GetAsync($"{_baseUrl}/universal-script/v1/result/{scriptId}");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }

        public void Dispose()
        {
            _httpClient?.Dispose();
        }
    }
}