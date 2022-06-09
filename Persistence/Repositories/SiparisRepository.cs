using BaseAPI.Domain.Models;
using BaseAPI.Domain.Repositories;
using BaseAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseAPI.Persistence.Repositories
{
    public class SiparisRepository : BaseRepository, ISiparisRepository
    {
        public SiparisRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Siparis>> ListAsync()
        {
            //return await _context.Siparis.ToListAsync();
            var List = await _context.Siparis.ToListAsync();
            return List;
        }
        public async Task AddAsync(Siparis siparis)
        {
            await _context.Siparis.AddAsync(siparis);
        }
        public async Task<Siparis> FindByIdAsync(int id)
        {
            return await _context.Siparis.FindAsync(id);
        }
        public async Task<IEnumerable<Siparis>> FindByUserIDAsync(int userID)
        {
            var List = await _context.Siparis.Where(p => p.UserId==userID)
                                        .ToListAsync();
            return List;
        }
        public void Update(Siparis siparis)
        {
            _context.Siparis.Update(siparis);
        }
        public void Remove(Siparis siparis)
        {
            _context.Siparis.Remove(siparis);
        }
    }
}
