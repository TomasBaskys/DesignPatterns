using System;

namespace Prototype
{
    public class CloneableProduct : ICloneable
    {
        public double Price { get; set; }

        public CloneableProduct(double price)
        {
            Price = price;
        }

        public object Clone()
        {
            //Shallow Copy
            return this.MemberwiseClone();
        }
    }
}