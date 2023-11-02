using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace Entities.Entities.Users
{
    public class Role : IdentityRole<long>, IEntity
    {
        [Required]
        [StringLength(100)]
        public string Description { get; set; }
    }

    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
        }
    }
}
