using BaseAPI.Core.Models;
using System.Threading.Tasks;

namespace BaseAPI.Core.Repositories
{
    public interface IUserRepository
    {
        Task AddAsync(User user, ERole[] userRoles);
        Task<User> FindByEmailAsync(string email);

        void Update(User user);
    }
}