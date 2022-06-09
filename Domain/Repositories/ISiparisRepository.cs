using BaseAPI.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BaseAPI.Domain.Repositories
{
    public interface ISiparisRepository
    {
        Task<IEnumerable<Siparis>> ListAsync();
        Task AddAsync(Siparis siparis);
        Task<Siparis> FindByIdAsync(int id);
        void Update(Siparis siparis);
        void Remove(Siparis siparis);
        Task<IEnumerable<Siparis>> FindByUserIDAsync(int userID);
    }
}
