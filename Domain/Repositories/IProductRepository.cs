using EnglishHomeAPI.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EnglishHomeAPI.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> ListAsync();
    }
}
