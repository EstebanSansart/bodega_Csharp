namespace Core.Entities;

public class Estado
{
    public int Id { get; set; }
    public string ? Description { get; set; }
    public ICollection<Producto> ? Productos { get; set; }
    
}