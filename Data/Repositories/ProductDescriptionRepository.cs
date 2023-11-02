using Common;
using Data.Contracts;
using Entities.Products;

namespace Data.Repositories
{
    public class ProductDescriptionRepository : Repository<ProductDescription>, IProductDescriptionRepository, IScopedDependency
    {
        public ProductDescriptionRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
