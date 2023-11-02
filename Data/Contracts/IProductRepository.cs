using Data.Repositories;
using Entities.Products;

namespace Data.Contracts
{
    public interface IProductRepository : IRepository<Product>
    {
    }
}
