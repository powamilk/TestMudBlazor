using Azure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDAL.Repo.Interface
{
    public interface IApiService
    {
        Task<T?> GetAsync<T>(string endpoint);
        Task<TResponse?> PostAsync<TRequest, TResponse>(string endpoint, TRequest request); 
        Task PutAsync<TRequest>(string endpoint, TRequest request);
        Task DeleteAsync(string endpoint);
    }
}
