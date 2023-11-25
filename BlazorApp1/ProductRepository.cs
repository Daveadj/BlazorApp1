using BlazorApp1.Data;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.contracts;

namespace BlazorApp1
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task Create(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Product product)
        {
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Product>> GetAllProducts()
        {
            var product = await _context.Products.ToListAsync();
            return product;
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
            return product;
        }

        public async Task Update(Product product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }
    }
}