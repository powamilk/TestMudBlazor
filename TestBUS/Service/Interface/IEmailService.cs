using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBUS.ViewModel.Email;

namespace TestBUS.Service.Interface
{
    public interface IEmailService
    {
        Task<List<EmailVM>> GetAllAsync();
        Task<EmailVM> GetByIdAsync(int id);
        Task AddAsync(EmailCreateVM emailCreateVM);
        Task UpdateAsync(EmailUpdateVM emailUpdateVM);
        Task DeleteAsync(int id);
        Task<List<EmailVM>> GetByUserIdAsync(int userId);
    }
}
