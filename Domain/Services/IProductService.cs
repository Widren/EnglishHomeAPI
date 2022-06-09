using BaseAPI.Domain.Models;
using BaseAPI.Domain.Services.Communication;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BaseAPI.Domain.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> ListAsync();
        Task<ProductResponse> SaveAsync(Product product);
        Task<ProductResponse> UpdateAsync(int id, Product product);
        Task<ProductResponse> DeleteAsync(int id);
    }
}
