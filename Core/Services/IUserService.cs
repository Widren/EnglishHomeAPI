using BaseAPI.Core.Models;
using BaseAPI.Core.Services.Communication;
using System.Threading.Tasks;

namespace BaseAPI.Core.Services
{
    public interface IUserService
    {
        Task<CreateUserResponse> CreateUserAsync(User user, params ERole[] userRoles);
        Task<User> FindByEmailAsync(string email);
        Task<CreateUserResponse> UpdateAsync(string email, User user);
    }
}