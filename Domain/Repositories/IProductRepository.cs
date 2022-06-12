using BaseAPI.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BaseAPI.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> ListAsync();
    }
}
