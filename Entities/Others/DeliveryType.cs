using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Entities.Others
{
    public class DeliveryType : BaseEntity<int>
    {
        public string Title { get; set; }
        public int StatusId { get; set; }
        public int PriorityId { get; set; }

        public Status Status { get; set; }
    }
    public class DeliveryTypesConfiguration : IEntityTypeConfiguration<DeliveryType>
    {
        public void Configure(EntityTypeBuilder<DeliveryType> builder)
        {
            builder.HasOne(p => p.Status).WithMany(c => c.DeliveryTypes).HasForeignKey(p => p.StatusId);
        }
    }
}