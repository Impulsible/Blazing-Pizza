namespace BlazingPizza.Data;

public class PizzaService
{
    public async Task<List<PizzaSpecial>> GetPizzasAsync()
    {
        await Task.Delay(100);
        
        return new List<PizzaSpecial>
        {
            new PizzaSpecial { Id = 1, Name = "Basic Cheese Pizza", Description = "It's cheesy and delicious", BasePrice = 9.99m, ImageUrl = "/img/pizzas/cheese.jpg" },
            new PizzaSpecial { Id = 2, Name = "The Baconatorizor", Description = "It has EVERY kind of bacon", BasePrice = 11.99m, ImageUrl = "/img/pizzas/bacon.jpg" },
            new PizzaSpecial { Id = 3, Name = "Classic pepperoni", Description = "Classic pepperoni pizza", BasePrice = 10.50m, ImageUrl = "/img/pizzas/pepperoni.jpg" },
            new PizzaSpecial { Id = 4, Name = "Buffalo chicken", Description = "Spicy chicken with blue cheese", BasePrice = 12.75m, ImageUrl = "/img/pizzas/meaty.jpg" },
            new PizzaSpecial { Id = 5, Name = "Mushroom Lovers", Description = "Loaded with mushrooms", BasePrice = 11.00m, ImageUrl = "/img/pizzas/mushroom.jpg" },
            new PizzaSpecial { Id = 6, Name = "Veggie Delight", Description = "Fresh vegetables", BasePrice = 11.50m, ImageUrl = "/img/pizzas/salad.jpg" },
            new PizzaSpecial { Id = 7, Name = "Margherita", Description = "Traditional Italian pizza", BasePrice = 9.99m, ImageUrl = "/img/pizzas/margherita.jpg" },
        };
    }
}