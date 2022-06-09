using BaseAPI.Domain.Models;
using BaseAPI.Domain.Services.Communication;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BaseAPI.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
        Task<CategoryResponse> SaveAsync(Category category);
        Task<CategoryResponse> UpdateAsync(int id, Category category);
        Task<CategoryResponse> DeleteAsync(int id);
    }
}
