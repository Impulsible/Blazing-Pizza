using BlazingPizza;

namespace BlazingPizza.Data;

public class PizzaService
{
    public async Task<List<PizzaSpecial>> GetPizzasAsync()
    {
        await Task.Delay(100);
        
        return new List<PizzaSpecial>
        {
            new PizzaSpecial { Id = 1, Name = "Buffalo Chicken", Description = "Spicy chicken, hot sauce and bleu cheese, guaranteed to warm you up", BasePrice = 12.75m, ImageUrl = "https://images.unsplash.com/photo-1513104890138-7c749659a591?w=300&h=180&fit=crop" },
            new PizzaSpecial { Id = 2, Name = "The Baconatorizor", Description = "It has EVERY kind of bacon", BasePrice = 11.99m, ImageUrl = "https://images.unsplash.com/photo-1565299624946-b28f40a0ae38?w=300&h=180&fit=crop" },
            new PizzaSpecial { Id = 3, Name = "Veggie Delight", Description = "It's like salad, but on a pizza", BasePrice = 11.50m, ImageUrl = "https://images.unsplash.com/photo-1574071318508-1cdbab80d002?w=300&h=180&fit=crop" },
            new PizzaSpecial { Id = 4, Name = "Mushroom Lovers", Description = "It has mushrooms. Isn't that obvious?", BasePrice = 11.00m, ImageUrl = "https://images.unsplash.com/photo-1534308983496-4fabb1a015ee?w=300&h=180&fit=crop" },
            new PizzaSpecial { Id = 5, Name = "Classic Pepperoni", Description = "It's the pizza you grew up with, but Blazing hot!", BasePrice = 10.50m, ImageUrl = "https://images.unsplash.com/photo-1628840042765-356cda07504e?w=300&h=180&fit=crop" },
            new PizzaSpecial { Id = 6, Name = "Basic Cheese Pizza", Description = "It's cheesy and delicious. Why wouldn't you want one?", BasePrice = 9.99m, ImageUrl = "https://images.unsplash.com/photo-1548369937-47519962c11a?w=300&h=180&fit=crop" },
            new PizzaSpecial { Id = 7, Name = "Margherita", Description = "Traditional Italian pizza with tomatoes and basil", BasePrice = 9.99m, ImageUrl = "https://images.unsplash.com/photo-1574071318508-1cdbab80d002?w=300&h=180&fit=crop" },
        };
    }
}