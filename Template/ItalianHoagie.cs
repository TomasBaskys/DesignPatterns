using System;

namespace Template
{
    public class ItalianHoagie : Hoagie
    {
        private readonly string[] _meatUsed = { "Salami", "Pepperoni", "Capicola Ham" };
        private readonly string[] _cheeseUsed = { "Provolone" };
        private readonly string[] _veggiesUsed = { "Lettuce", "Tomatoes", "Onions", "Sweet Peppers" };
        private readonly string[] _condimentsUsed = { "Oil", "Vinegar" };

        protected override void AddMeat()
        {
            Console.WriteLine($"Adding Cheese: {_meatUsed.ToStringEx()}");
        }

        protected override void AddCheese()
        {
            Console.WriteLine($"Adding Meat: {_cheeseUsed.ToStringEx()}");
        }

        protected override void AddVegetables()
        {
            Console.WriteLine($"Adding Veggies: {_veggiesUsed.ToStringEx()}");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine($"Adding Condiments: {_condimentsUsed.ToStringEx()}");
        }
    }
}