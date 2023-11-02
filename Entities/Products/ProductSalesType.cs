using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Entities.Others;

namespace Entities.Products
{
    public class ProductSalesType : BaseEntity<int>
    {
        public string Title { get; set; }
        public int StatusId { get; set; }


        public Status Status { get; set; }


        public ICollection<Product> Products { get; set; }
    }
    public class ProductSalesTypesConfiguration : IEntityTypeConfiguration<ProductSalesType>
    {
        public void Configure(EntityTypeBuilder<ProductSalesType> builder)
        {
            builder.HasOne(p => p.Status).WithMany(c => c.ProductSalesTypes).HasForeignKey(p => p.StatusId);
        }
    }
}
