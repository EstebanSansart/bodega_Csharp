namespace Core.Entities;

public class MiBodegaContext
{
    [Key]
    public string? IdBodega { get; set; }
    public string? NameCellar { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

}