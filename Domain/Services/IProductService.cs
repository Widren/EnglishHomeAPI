using EnglishHomeAPI.Domain.Models;
using EnglishHomeAPI.Domain.Services.Communication;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EnglishHomeAPI.Domain.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> ListAsync();
    }
}
