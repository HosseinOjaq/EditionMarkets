using Common;
using Data.Contracts;
using Entities.Products;

namespace Data.Repositories
{
    public class ProductTypeRepository : Repository<ProductType>, IProductTypeRepository, IScopedDependency
    {
        public ProductTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
