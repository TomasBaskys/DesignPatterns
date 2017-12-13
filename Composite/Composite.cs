namespace Composite
{
    public class Composite
    {
        public static void Main()
        {
            var root = new CompositeElement("Picture");

            root.Add(new PrimitiveElement("Red Line"));
            root.Add(new PrimitiveElement("Green Line"));
            root.Add(new PrimitiveElement("Blue Line"));


            var composition = new CompositeElement("Two Circles");

            composition.Add(new PrimitiveElement("Black Circle"));
            composition.Add(new PrimitiveElement("White Circle"));
            root.Add(composition);


            var composition1 = new CompositeElement("Two Squares");

            composition1.Add(new PrimitiveElement("Black Square"));
            composition1.Add(new PrimitiveElement("White Square"));
            root.Add(composition1);

            var primitiveElement = new PrimitiveElement("Line");
            root.Add(primitiveElement);
            root.Remove(primitiveElement);

            root.Display(5);
        }
    }
}