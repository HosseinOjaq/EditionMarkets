using Common;
using Data.Contracts;
using Entities.Products;

namespace Data.Repositories
{
    public class ProductCommentRepository : Repository<ProductComment>, IProductCommentRepository, IScopedDependency
    {
        public ProductCommentRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
