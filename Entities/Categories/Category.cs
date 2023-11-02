using System.Collections.Generic;

namespace Entities.Categories
{
    public class Category : BaseEntity<long>
    {
        public string Title { get; set; }

        public ICollection<SubCategory> SubCategories { get; set; }
    }
}
