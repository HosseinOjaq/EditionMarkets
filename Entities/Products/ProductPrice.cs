using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;

namespace Entities.Products
{
    public class ProductPrice : BaseEntity<long>
    {
        public decimal Price { get; set; }
        public long ProductId { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public long ProductTypeId { get; set; }

        public Product Product { get; set; }
        public ProductType ProductType { get; set; }
    }

    public class ProductPricesConfiguration : IEntityTypeConfiguration<ProductPrice>
    {
        public void Configure(EntityTypeBuilder<ProductPrice> builder)
        {
            builder.HasOne(p => p.ProductType).WithMany(c => c.ProductPrices).HasForeignKey(p => p.ProductTypeId);

            builder.HasOne(p => p.Product).WithMany(c => c.ProductPrices).HasForeignKey(p => p.ProductId);

        }
    }
}
