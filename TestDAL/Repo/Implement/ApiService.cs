using Azure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using TestDAL.Repo.Interface;

namespace TestDAL.Repo.Implement
{
    public class ApiService : IApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7163")
            };
            Console.WriteLine($"HttpClient BaseAdres : {_httpClient.BaseAddress}");
        }
        public async Task DeleteAsync(string endpoint)
        {
            var response = await _httpClient.DeleteAsync(endpoint);
            response.EnsureSuccessStatusCode();
        }

        public async Task<T?> GetAsync<T>(string endpoint)
        {
            return await _httpClient.GetFromJsonAsync<T>(endpoint); 
        }

        public async Task<TResponse?> PostAsync<TRequest, TResponse>(string endpoint, TRequest request)
        {
            var response = await _httpClient.PostAsJsonAsync(endpoint, request);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<TResponse>();
        }

        public async Task PutAsync<TRequest>(string endpoint, TRequest request)
        {
            var response = await _httpClient.PutAsJsonAsync(endpoint, request);
            response.EnsureSuccessStatusCode();
        }
    }
}
