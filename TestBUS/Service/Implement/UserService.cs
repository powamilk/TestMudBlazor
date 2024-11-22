using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBUS.Service.Interface;
using TestBUS.ViewModel.User;
using TestDAL.Repo.Interface;

namespace TestBUS.Service.Implement
{
    public class UserService : IUserService
    {
        private readonly IApiService _api;
        public UserService(IApiService api)
        {
            _api = api;
        }
        public async Task CreateAsync(UserCreateVM vm)
        {
            await _api.PostAsync<UserCreateVM, object>("api/User", vm);
        }

        public async Task DeleteAsync(int id)
        {
            if(id <= 0)
            {
                throw new ArgumentException("Id Khong ton tai");
            }
            await _api.DeleteAsync($"api/User/{id}");
        }

        public async Task<List<UserVM>> GetAllAsync()
        {
            try
            {
                return await _api.GetAsync<List<UserVM>>("api/User");
            }
            catch (Exception ex)
            {
                {
                    Console.WriteLine($"Co loi xay ra :{ex.Message}");
                    throw;
                }

            }
        }

        public async Task<UserVM> GetByIdAsync(int id)
        {
            return await _api.GetAsync<UserVM>($"api/User/{id}");
        }

        public async Task UpdateAsync(int id, UserUpdateVM vm)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Id Khong ton tai");
            }
            vm.UserId = id;
            await _api.PutAsync($"api/User/{id}", vm);
        }
    }
}
