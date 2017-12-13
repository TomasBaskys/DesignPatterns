namespace Prototype
{
    public class Bread : ProductPrototype
    {
        public Bread(double price) : base(price)
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