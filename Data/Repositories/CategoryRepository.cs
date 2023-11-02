using Common;
using Data.Contracts;
using Entities.Categories;
using Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoriyRepository, IScopedDependency
    {
        public CategoryRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
