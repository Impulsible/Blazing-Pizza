namespace BlazingPizza;

public class Pizza
{
    public const int DefaultSize = 12;
    public const int MinimumSize = 9;
    public const int MaximumSize = 17;

    public int Id { get; set; }
    public int SpecialId { get; set; }
    public PizzaSpecial Special { get; set; } = new PizzaSpecial();
    public int Size { get; set; } = DefaultSize;
    public List<PizzaTopping> Toppings { get; set; } = new List<PizzaTopping>();

    public decimal GetBasePrice()
    {
        return ((decimal)Size / (decimal)DefaultSize) * Special.BasePrice;
    }

    public decimal GetToppingsPrice()
    {
        return Toppings.Sum(t => t.Topping?.Price ?? 0);
    }

    public decimal GetTotalPrice()
    {
        return GetBasePrice() + GetToppingsPrice();
    }

    public string GetFormattedTotalPrice()
    {
        return GetTotalPrice().ToString("0.00");
    }
}