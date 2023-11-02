using Common;
using Data.Contracts;
using Entities.Properties;

namespace Data.Repositories
{
    public class PropertyItemPricesRepository : Repository<PropertyItemPrice>, IPropertyItemPriceRepository, IScopedDependency
    {
        public PropertyItemPricesRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
