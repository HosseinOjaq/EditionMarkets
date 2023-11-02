using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using Entities.Products;

namespace Entities.Properties
{
    public class PropertyItemPrice : BaseEntity<long>
    {
        public decimal ItemPrice { get; set; }
        public long ProductId { get; set; }
        public long PropertyItemId { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;

        public Product Product { get; set; }
        public PropertyItem propertyItem { get; set; }

    }
    public class PropertyItemPricesConfiguration : IEntityTypeConfiguration<PropertyItemPrice>
    {
        public void Configure(EntityTypeBuilder<PropertyItemPrice> builder)
        {
            builder.HasOne(p => p.Product).WithMany(c => c.PropertyItemPrices).HasForeignKey(p => p.ProductId);

            builder.HasOne(p => p.propertyItem).WithMany(c => c.propertyItems).HasForeignKey(p => p.PropertyItemId);
        }
    }
}
