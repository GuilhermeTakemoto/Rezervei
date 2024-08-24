using Rezervei.Object.Models;

namespace Rezervei.Repositories.Interfaces
{
    public class IUserRepository
    {
        Task<IEnumerable<UserModel>> GetAll();
        Task<UserModel> GetById(int id);
        Task<UserModel> Create(UserModel userModel);
        Task<UserModel> Update(UserModel userModel);
        Task<UserModel> Delete(UserModel userModel);
    }
}
