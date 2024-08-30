using Rezervei.Object.Contracts;
using Rezervei.Object.DTOs.Entities;
using Rezervei.Object.Models.Entities;

namespace Rezervei.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<UserModel>> GetAll();
        Task<UserModel> GetById(int id);
        Task<UserModel> GetByEmail(string email);
        Task<UserModel> Login(string login);
        Task<UserModel> Create(UserModel userModel);
        Task<UserModel> Update(UserModel userModel);
        Task<UserModel> Delete(UserModel userModel);
        Task Create(UserDTO userModel);
    }
}
