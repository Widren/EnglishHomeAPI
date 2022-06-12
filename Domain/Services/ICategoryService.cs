using EnglishHomeAPI.Domain.Models;
using EnglishHomeAPI.Domain.Services.Communication;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EnglishHomeAPI.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}
