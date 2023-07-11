using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("User");
        builder.Property(p => p.Id).isRequired();
        builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
        builder.Property(p => p.Email).IsRequired().HasMaxLength(50);
        builder.Property(p => p.UpdateDate).IsRequired().HasColumnType("date");
        builder.Property(p => p.Picture).IsRequired().HasMaxLength(100);
        builder.Property(p => p.Password).IsRequired().HasMaxLength(50);
    }
}