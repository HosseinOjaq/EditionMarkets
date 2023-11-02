using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Entities.Products;

namespace Entities.Categories
{
    public class SubCategory : BaseEntity<long>
    {
        public string Title { get; set; }
        public long CategoryId { get; set; }

        public Category Categoriy { get; set; }


        public ICollection<ProductDiscount> ProductDiscounts { get; set; }
        public ICollection<Product> Products { get; set; }
    }
    public class SubCategoriesConfiguration : IEntityTypeConfiguration<SubCategory>
    {
        public void Configure(EntityTypeBuilder<SubCategory> builder)
        {
            builder.HasOne(p => p.Categoriy).WithMany(c => c.SubCategories).HasForeignKey(p => p.CategoryId);

        }
    }
}
