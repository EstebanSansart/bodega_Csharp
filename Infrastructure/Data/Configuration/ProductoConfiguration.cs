using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
{
    public void Configure(EntityTypeBuilder<Producto> builder)
    {
        builder.ToTable("Producto");
        builder.Property(p => p.Id).isRequired();
        builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
        builder.Property(p => p.Description).IsRequired().HasMaxLength(255);
        builder.Property(p => p.Quantity).IsRequired();
        builder.Property(p => p.CreatedAt).IsRequired().HasColumnType("date");
        builder.Property(p => p.UpdatedAt).IsRequired().HasColumnType("date");
        builder.Property(p => p.Price).IsRequired().HasColumnType("double");
        builder.HasOne(p => p.Estado).WithMany(e => e.Productos).HasForeignKey(i => i.EstadoId)
    }
}