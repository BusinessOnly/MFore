using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Metrafor.Domain.Entries;

namespace Metrafor.Migrations.Configurations
{
    public sealed class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(et => et.UserId);
            builder.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(256);
            builder.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(16);

            builder.HasIndex(e => e.Login)
                .IsUnique()
                .HasFilter(null);
        }
    }
}
