using Common;
using Data.Contracts;
using Entities.Properties;

namespace Data.Repositories
{
    public class PropertyItemsRepository : Repository<PropertyItem>, IPropertyItemRepository, IScopedDependency
    {
        public PropertyItemsRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
