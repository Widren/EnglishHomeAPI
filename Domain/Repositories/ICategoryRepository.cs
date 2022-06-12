using EnglishHomeAPI.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EnglishHomeAPI.Domain.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}
