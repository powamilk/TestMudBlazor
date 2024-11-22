using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBUS.ViewModel.User;

namespace TestBUS.Service.Interface
{
    public interface IUserService
    {
        Task<List<UserVM>> GetAllAsync();
        Task<UserVM> GetByIdAsync(int id);
        Task CreateAsync(UserCreateVM vm);
        Task UpdateAsync(int id, UserUpdateVM vm);
        Task DeleteAsync(int id);
    }
}
