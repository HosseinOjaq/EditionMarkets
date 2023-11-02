using Common;
using Data.Contracts;
using Entities.Products;

namespace Data.Repositories
{
    public class ProductDiscountRepository : Repository<ProductDiscount>, IProductDiscountRepository, IScopedDependency
    {
        public ProductDiscountRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
