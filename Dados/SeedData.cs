namespace BlazingPizza.Data;

public static class SeedData
{
    public static void Initialize(PizzaStoreContext db)
    {
        var specials = new PizzaSpecial[]
        {
            new PizzaSpecial()
            {
                Name = "Pizza Básica de Queijo",
                Description = "É deliciosa e com muito queijo. Quem não gostaria de uma?",
                BasePrice = 90,
                ImageUrl = "img/pizzas/cheese.jpg",
            },
            new PizzaSpecial()
            {
                Id = 2,
                Name = "A Baconator",
                Description = "Tem TODOS os tipos de bacon",
                BasePrice = 100m,
                ImageUrl = "img/pizzas/bacon.jpg",
            },
            new PizzaSpecial()
            {
                Id = 3,
                Name = "Pepperoni Clássico",
                Description = "É a pizza da sua infância, mas super picante!",
                BasePrice = 85.99m,
                ImageUrl = "img/pizzas/pepperoni.jpg",
            },
            new PizzaSpecial()
            {
                Id = 4,
                Name = "Frango Buffalo",
                Description = "Frango picante, molho apimentado e queijo gorgonzola, garantia de te aquecer.",
                BasePrice = 92.75m,
                ImageUrl = "img/pizzas/meaty.jpg",
            },
            new PizzaSpecial()
            {
                Id = 5,
                Name = "Amantes de Cogumelos",
                Description = "Tem cogumelos. Não é óbvio?",
                BasePrice = 81.00m,
                ImageUrl = "img/pizzas/mushroom.jpg",
            },
            new PizzaSpecial()
            {
                Id = 7,
                Name = "Delícia Vegetariana",
                Description = "É como uma salada, só que numa pizza.",
                BasePrice = 91.50m,
                ImageUrl = "img/pizzas/salad.jpg",
            },
            new PizzaSpecial()
            {
                Id = 8,
                Name = "Margherita",
                Description = "Pizza tradicional italiana com tomates e manjericão.",
                BasePrice = 99.99m,
                ImageUrl = "img/pizzas/margherita.jpg",
            },
        };
        db.Specials.AddRange(specials);
        db.SaveChanges();
    }
}