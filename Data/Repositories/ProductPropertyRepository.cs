using Common;
using Data.Contracts;
using Entities.Products;
using System.ComponentModel.DataAnnotations;

namespace Data.Repositories
{
    public class ProductPropertyRepository : Repository<ProductProperty>, IProductPropertyRepository, IScopedDependency
    {
        public ProductPropertyRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
