namespace BlazingPizza.Data;

public class PizzaSpecial
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public decimal BasePrice { get; set; }
    public string ImageUrl { get; set; } = "";
    
    // Format price in Nigerian Naira (₦)
    public string GetFormattedPrice()
    {
        return $"₦{BasePrice:N2}";
    }
}