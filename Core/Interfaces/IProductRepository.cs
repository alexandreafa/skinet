using Core.Entities;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetProductByIdAsync(int id);
        Task<IReadOnlyList<Product>> GetProducsAsync();
        Task<IReadOnlyList<ProductBrand>> GetProducBrandsAsync();
        Task<IReadOnlyList<ProductType>> GetProducTypesAsync();
    }
}