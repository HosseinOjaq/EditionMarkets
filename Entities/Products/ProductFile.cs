using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Entities.Others;

namespace Entities.Products
{
    public class ProductFile : BaseEntity<long>
    {
        public string Title { get; set; }
        public long ProductId { get; set; }
        public string FileName { get; set; }
        public int StatusId { get; set; }

        public Product Product { get; set; }
        public Status Status { get; set; }
    }
    public class ProductFilesConfiguration : IEntityTypeConfiguration<ProductFile>
    {
        public void Configure(EntityTypeBuilder<ProductFile> builder)
        {
            builder.HasOne(p => p.Product).WithMany(c => c.ProductFiles).HasForeignKey(p => p.ProductId);

            builder.HasOne(p => p.Status).WithMany(c => c.ProductFiles).HasForeignKey(p => p.StatusId);

        }
    }
}
