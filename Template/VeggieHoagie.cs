using System;

namespace Template
{
    public class VeggieHoagie : Hoagie
    {
        private readonly string[] _veggiesUsed = { "Lettuce", "Tomatoes", "Onions", "Sweet Peppers" };
        private readonly string[] _condimentsUsed = { "Oil", "Vinegar" };

        public VeggieHoagie()
        {
            WantsMeat = false;
            WantsCheese = false;
        }

        protected override void AddMeat() { }

        protected override void AddCheese() { }

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