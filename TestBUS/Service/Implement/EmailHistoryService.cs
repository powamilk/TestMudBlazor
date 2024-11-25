using BUS.Service.Interface;
using BUS.ViewModel.EmailHistory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDAL.Repo.Interface;

namespace BUS.Service.Implement
{
    public class EmailHistoryService : IEmailHistoryService
    {
        private readonly IApiService _apiService;

        public EmailHistoryService(IApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<List<EmailHistoryVM>> GetAllAsync()
        {
            return await _apiService.GetAsync<List<EmailHistoryVM>>("api/emailhistory");
        }

        public async Task<EmailHistoryVM> GetByIdAsync(int id)
        {
            return await _apiService.GetAsync<EmailHistoryVM>($"api/emailhistory/{id}");
        }

        public async Task<List<EmailHistoryVM>> GetByEmailIdAsync(int emailId)
        {
            return await _apiService.GetAsync<List<EmailHistoryVM>>($"api/emailhistory/email/{emailId}");
        }

        public async Task AddAsync(EmailHistoryCreateVM emailHistoryCreateVM)
        {
            await _apiService.PostAsync<EmailHistoryCreateVM, object>("api/emailhistory", emailHistoryCreateVM);
        }

        public async Task UpdateAsync(EmailHistoryUpdateVM emailHistoryUpdateVM)
        {
            await _apiService.PutAsync($"api/emailhistory/{emailHistoryUpdateVM.HistoryId}", emailHistoryUpdateVM);
        }

        public async Task DeleteAsync(int id)
        {
            await _apiService.DeleteAsync($"api/emailhistory/{id}");
        }
    }
}
