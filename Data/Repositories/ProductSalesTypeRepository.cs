using Common;
using Data.Contracts;
using Entities.Products;

namespace Data.Repositories
{
    public class ProductSalesTypeRepository : Repository<ProductSalesType>, iProductSalesTypesRepository, IScopedDependency
    {
        public ProductSalesTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
