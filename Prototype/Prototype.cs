using System;

namespace Prototype
{
    public class Prototype
    {
        public static void Main()
        {
            var supermarket = new Supermarket();

            supermarket.AddProduct("Milk", new Milk(0.89));
            supermarket.AddProduct("Bread", new Bread(1.11));

            double sourcePrice;
            double currentPrice;

            var cloneMilk = (Milk)supermarket.GetProduct("Milk");
            cloneMilk.Price = 1;
            sourcePrice = supermarket.GetProduct("Milk").Price;
            currentPrice = cloneMilk.Price;
            Console.WriteLine($"{sourcePrice} | {currentPrice}");

            var cloneBread = (Bread)supermarket.GetProduct("Bread");
            cloneBread.Price = 2;
            sourcePrice = supermarket.GetProduct("Bread").Price;
            currentPrice = cloneBread.Price;
            Console.WriteLine($"{sourcePrice} | {currentPrice}");

            //ICloneable
            var cloneableProduct = new CloneableProduct(100);
            var clonedProduct = (CloneableProduct)cloneableProduct.Clone();
            clonedProduct.Price = 200;
            sourcePrice = cloneableProduct.Price;
            currentPrice = clonedProduct.Price;
            Console.WriteLine($"{sourcePrice} | {currentPrice}");
        }
    }
}