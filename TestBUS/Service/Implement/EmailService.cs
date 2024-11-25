using BUS.Service.Interface;
using BUS.ViewModel.Email;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDAL.Repo.Interface;

namespace BUS.Service.Implement
{
    public class EmailService : IEmailService
    {
        private readonly IApiService _apiService;

        public EmailService(IApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<List<EmailVM>> GetAllAsync()
        {
            return await _apiService.GetAsync<List<EmailVM>>("api/email");
        }

        public async Task<EmailVM> GetByIdAsync(int id)
        {
            return await _apiService.GetAsync<EmailVM>($"api/email/{id}");
        }

        public async Task AddAsync(EmailCreateVM emailCreateVM)
        {
            await _apiService.PostAsync<EmailCreateVM, object>("api/email", emailCreateVM);
        }

        public async Task UpdateAsync(EmailUpdateVM emailUpdateVM)
        {
            await _apiService.PutAsync($"api/email/{emailUpdateVM.EmailId}", emailUpdateVM);
        }

        public async Task DeleteAsync(int id)
        {
            await _apiService.DeleteAsync($"api/email/{id}");
        }

        public async Task<List<EmailVM>> GetByUserIdAsync(int userId)
        {
            return await _apiService.GetAsync<List<EmailVM>>($"api/email/user/{userId}");
        }
    }
}
