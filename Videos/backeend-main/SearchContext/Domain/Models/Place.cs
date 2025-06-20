namespace workstation_backend.SearchContext.Domain.Models;

public class Place {
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty; 
    public string Description { get; set; } = "Espacio disponible";
    public string Location { get; set; } = "Ubicación desconocida";
    public double Rating { get; set; } = 0.0;
    public int Reviews { get; set; } = 0;
    public bool IsReserved { get; set; }
}