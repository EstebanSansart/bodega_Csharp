using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class ProductoUserConfiguration : IEntityTypeConfiguration<ProductoUser>
{
    public void Configure(EntityTypeBuilder<ProductoUser> builder)
    {
        builder.ToTable("ProductoUser");
        builder.HasOne(p => p.Productos).WithMany(e => e.ProductosUsers).HasForeignKey(i => i.ProductoId);
        builder.HasOne(p => p.Users).WithMany(e => e.ProductoUsers).HasForeignKey(i => i.UserId);
    }
}