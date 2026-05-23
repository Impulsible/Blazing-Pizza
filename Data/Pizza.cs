namespace BlazingPizza.Data;

/// <summary>
/// Represents a pizza that can be ordered
/// </summary>
public class Pizza
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public decimal Price { get; set; }
    public bool Vegetarian { get; set; }
    public bool Vegan { get; set; }
    public string ImageUrl { get; set; } = "";
    
    // Helper method to format price
    public string GetFormattedPrice() => Price.ToString("0.00");
}