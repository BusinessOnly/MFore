using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Metrafor.Domain.Entries;

namespace Metrafor.Migrations.Configurations
{
    public sealed class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("Person");
            builder.HasKey(et => et.PersonId);
            builder.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(256);
            builder.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(256);
            builder.Property(e => e.Patronymic)
                    .IsRequired()
                    .HasMaxLength(256);
            builder.Property(e => e.Inn)
                    .IsRequired()
                    .HasMaxLength(32);
            builder.Property(e => e.PassportSeries)
                    .IsRequired()
                    .HasMaxLength(32);
            builder.Property(e => e.PassportNumber)
                    .IsRequired()
                    .HasMaxLength(32);
            builder.Property(e => e.PassportWho)
                    .IsRequired()
                    .HasMaxLength(1024);
            builder.Property(e => e.PassportWhen)
                    .IsRequired()
                    .HasMaxLength(256);
            builder.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(32);
            builder.Property(e => e.AddressCity)
                    .IsRequired()
                    .HasMaxLength(64);
            builder.Property(e => e.AddressStreet)
                    .IsRequired()
                    .HasMaxLength(256);
            builder.Property(e => e.AddressHouse)
                    .IsRequired()
                    .HasMaxLength(32);
            builder.Property(e => e.Position)
                    .IsRequired()
                    .HasMaxLength(32);
        }
    }
}
