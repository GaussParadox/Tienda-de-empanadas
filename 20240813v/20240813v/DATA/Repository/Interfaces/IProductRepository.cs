using _20240813v.DATA.Models;

namespace _20240813v.DATA.Repository.Interfaces
{
    public interface IProductRepository
    {

        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product?> GetProductByIdAsync(string id);
        Task CreateProductAsync(Product product);
        Task<bool> UpdateProductAsync(string id, Product product);
        Task<bool> DeleteProductAsync(string id);
    }
}