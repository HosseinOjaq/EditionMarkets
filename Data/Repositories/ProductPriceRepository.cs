using Common;
using Data.Contracts;
using Entities.Products;

namespace Data.Repositories
{
    public class ProductPriceRepository : Repository<ProductPrice>, IProductPriceRepository, IScopedDependency
    {
        public ProductPriceRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
