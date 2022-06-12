using BaseAPI.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BaseAPI.Domain.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}
