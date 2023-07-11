namespace Core.Entities;
public class MovimientoBodega
{
    [Key]
    public string? IdDocument { get; set; }
    public DateTime CreatedAt { get; set; }
    public string? IdOriginCellar { get; set; }
    
}