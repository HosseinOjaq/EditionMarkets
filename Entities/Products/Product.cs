using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Entities.Categories;
using Entities.Orders;
using Entities.Properties;
using Entities.Others;

namespace Entities.Products
{
    public class Product : BaseEntity<long>
    {
        public string ProductTitle { get; set; }
        public long SubCategoryId { get; set; }
        public int StatusId { get; set; }
        public long ProductTypeId { get; set; }
        public string ProductDescription { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public int ProductCode { get; set; }
        public int ProductSalesTypeId { get; set; }



        public ProductSalesType ProductSalesType { get; set; }
        public SubCategory SubCategoriy { get; set; }
        public ProductType ProductType { get; set; }
        public Status Status { get; set; }




        public ICollection<OrderDetail> OrderDetails { get; set; }
        public ICollection<ProductComment> ProductComments { get; set; }
        public ICollection<ProductDescription> ProductDescriptions { get; set; }
        public ICollection<ProductFile> ProductFiles { get; set; }
        public ICollection<ProductPrice> ProductPrices { get; set; }
        public ICollection<ProductProperty> ProductProperties { get; set; }
        public ICollection<PropertyItemPrice> PropertyItemPrices { get; set; }


    }

    public class ProductsConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasOne(p => p.SubCategoriy).WithMany(c => c.Products).HasForeignKey(p => p.SubCategoryId);

            builder.HasOne(p => p.ProductType).WithMany(c => c.Products).HasForeignKey(p => p.ProductTypeId);

            builder.HasOne(p => p.Status).WithMany(c => c.Products).HasForeignKey(p => p.StatusId);

            builder.HasOne(p => p.ProductSalesType).WithMany(c => c.Products).HasForeignKey(p => p.ProductSalesTypeId);
        }
    }
}
