namespace Model.contracts
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllProducts();

        Task<Product> GetByIdAsync(int id);

        Task Create(Product product);

        Task Delete(Product product);

        Task Update(Product product);
    }
}