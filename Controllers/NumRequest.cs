namespace DevopsAPI.Controllers;

public record NumRequest
{
    public required int Number1 { get; init; }
    
    public required int Number2 { get; init; }
}