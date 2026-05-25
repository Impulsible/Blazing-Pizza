namespace BlazingPizza.Services;

public class OrderState
{
    public Order Order { get; private set; } = new Order();

    public void ResetOrder()
    {
        Order = new Order();
    }
}