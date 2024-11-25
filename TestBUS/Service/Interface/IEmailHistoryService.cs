using BUS.ViewModel.EmailHistory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service.Interface
{
    public interface IEmailHistoryService
    {
        Task<List<EmailHistoryVM>> GetAllAsync();
        Task<EmailHistoryVM> GetByIdAsync(int id);
        Task<List<EmailHistoryVM>> GetByEmailIdAsync(int emailId);
        Task AddAsync(EmailHistoryCreateVM emailHistoryCreateVM);
        Task UpdateAsync(EmailHistoryUpdateVM emailHistoryUpdateVM);
        Task DeleteAsync(int id);
    }
}
