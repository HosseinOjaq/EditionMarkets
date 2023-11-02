using Common;
using Data.Contracts;
using Entities.Products;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository, IScopedDependency
    {
        public ProductRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public async Task AddProduct()
        {

        }
    }
}
