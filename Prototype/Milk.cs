namespace Prototype
{
    public class Milk : ProductPrototype
    {
        public Milk(double price) : base(price)
        {
        }

        public override ProductPrototype Clone()
        {
            //Shallow Copy
            return (ProductPrototype)this.MemberwiseClone();

            //Deep Copy
            //return (ProductPrototype)this.Clone();
        }
    }
}