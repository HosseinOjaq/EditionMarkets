using Common;
using Data.Contracts;
using Entities.Categories;

namespace Data.Repositories
{
    public class SubCategoryRepository : Repository<SubCategory>, ISubCategoryRepository, IScopedDependency
    {
        public SubCategoryRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
