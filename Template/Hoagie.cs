using System;

namespace Template
{
    public abstract class Hoagie
    {
        protected bool WantsMeat = true;
        protected bool WantsCheese = true;
        protected bool WantsVegetables = true;
        protected bool WantsCondiments = true;

        public void MakeSandwich()
        {
            CutHoagie();

            if (WantsMeat) AddMeat();

            if (WantsCheese) AddCheese();

            if (WantsVegetables) AddVegetables();

            if (WantsCondiments) AddCondiments();

            WrapHoagie();
        }

        private void CutHoagie()
        {
            Console.WriteLine("The Hoagie is Cut");
        }

        protected abstract void AddMeat();
        protected abstract void AddCheese();
        protected abstract void AddVegetables();
        protected abstract void AddCondiments();

        private void WrapHoagie()
        {
            Console.WriteLine("Wrap the Hoagie\n");
        }
    }
}
