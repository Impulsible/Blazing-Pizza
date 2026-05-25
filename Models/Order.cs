namespace BlazingPizza;

public class Order
{
    public int OrderId { get; set; }
    public string UserId { get; set; } = "";
    public DateTime CreatedTime { get; set; } = DateTime.Now;
    public List<Pizza> Pizzas { get; set; } = new List<Pizza>();
    public decimal DeliveryPrice { get; set; } = 0;

    public decimal GetTotalPrice()
    {
        return Pizzas.Sum(p => p.GetTotalPrice()) + DeliveryPrice;
    }

    public string GetFormattedTotalPrice()
    {
        return GetTotalPrice().ToString("0.00");
    }
}