using BaseAPI.Domain.Models;
using BaseAPI.Domain.Repositories;
using BaseAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BaseAPI.Persistence.Repositories
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }


        public async Task<IEnumerable<Product>> ListAsync()//Product Category ilişkisi için, 1 e n ilişkide n olan bu kodu kullanmalı, n yani products.
        {
            return await _context.Products.ToListAsync();
        }
        public async Task AddAsync(Product product)//Ekle
        {
            await _context.Products.AddAsync(product);
        }
        public async Task<Product> FindByIdAsync(int id)//Bul
        {
            return await _context.Products.FindAsync(id);
        }
        public void Update(Product product)//Güncelle
        {
            _context.Products.Update(product);
        }
        public void Remove(Product product)//Kaldır
        {
            _context.Products.Remove(product);
        }
    }
}
