namespace Core.Entities;

public class ProductoUser
{
    public int ProductoId { get; set; }
    public Producto ? Productos { get; set; }
    public int UserId { get; set; }
    public User ? Users { get; set; }
}