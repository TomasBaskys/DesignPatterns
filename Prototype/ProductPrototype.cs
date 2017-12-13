namespace Prototype
{
    public abstract class ProductPrototype
    {
        public double Price { get; set; }

        public ProductPrototype(double price)
        {
            Price = price;
        }

        public abstract ProductPrototype Clone();
    }
}
