using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;
public class MiBodegaContext : DbContext
{
    public MiBodegaContext(DeContextOpyions<MiBodegaContext> options) : base(options){



    }
    public DbSet<Producto> ? Productos { get; set; }
    public DbSet<User> ? Users { get; set; }
    public DbSet<Bodega> ? Bodegas { get; set; }
    public DbSet<DetalleMovimiento> ? DetalleMovimientos { get; set; }
    public DbSet<MovimientoBodega> ? MovimientoBodegas { get; set;}
    public DbSet<Estado> ? Estados { get; set; }
    public DbSet<ProductoUser> ? ProductosUsers { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductoUser>().HasKey(e => new { e.ProductoId, e.UserId})
        base.OnModelBuilder(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}