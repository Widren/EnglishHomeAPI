using BaseAPI.Domain.Models;
using BaseAPI.Domain.Services.Communication;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BaseAPI.Domain.Services
{
    public interface ISiparisService
    {
        Task<IEnumerable<Siparis>> ListAsync();
        Task<SiparisResponse> SaveAsync(Siparis siparis);
        Task<SiparisResponse> UpdateAsync(int id, Siparis siparis);
        Task<SiparisResponse> DeleteAsync(int id);
        Task<IEnumerable<Siparis>> FindByUserIDAsync(int id);
    }
}

