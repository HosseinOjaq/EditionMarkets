using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Entities.Categories;

namespace Entities.Products
{
    public class ProductDiscount : BaseEntity<long>
    {
        public long SubCategoryId { get; set; }
        public long ProductTypeId { get; set; }
        public int DiscountPercent { get; set; }
        public decimal DiscountPrice { get; set; }
        public int FromCirculationOrMeterOrCount { get; set; }
        public int ToCirculationOrMeterOrCount { get; set; }
        public bool IsCooperation { get; set; }


        public SubCategory SubCategorie { get; set; }
        public ProductType ProductType { get; set; }
    }

    public class ProductDiscountsConfiguration : IEntityTypeConfiguration<ProductDiscount>
    {
        public void Configure(EntityTypeBuilder<ProductDiscount> builder)
        {
            builder.HasOne(p => p.SubCategorie).WithMany(c => c.ProductDiscounts).HasForeignKey(p => p.SubCategoryId);

            builder.HasOne(p => p.ProductType).WithMany(c => c.ProductDiscounts).HasForeignKey(p => p.ProductTypeId);
        }
    }
}
