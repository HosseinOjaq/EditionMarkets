using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Entities.Entities.Users;

namespace Entities.Users
{
    public class UserAddress : BaseEntity<long>
    {
        public string Title { get; set; }
        public long UserId { get; set; }
        public string Address { get; set; }
        public bool Assumption { get; set; }
        public string PostalCode { get; set; }


        public User User { get; set; }

    }
    public class UserAddressConfiguration : IEntityTypeConfiguration<UserAddress>
    {
        public void Configure(EntityTypeBuilder<UserAddress> builder)
        {
            builder.HasOne(p => p.User).WithMany(c => c.UserAddresses).HasForeignKey(p => p.UserId);
            builder.Property(p => p.Address).IsRequired();
        }
    }
}