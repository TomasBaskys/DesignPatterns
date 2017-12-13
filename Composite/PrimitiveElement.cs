using System;

namespace Composite
{
    public class PrimitiveElement : IDrawingElement
    {
        private readonly string _name;

        public PrimitiveElement(string name)
        {
            _name = name;
        }

        public void Add(IDrawingElement element)
        {
            Console.WriteLine("Cannot add to a PrimitiveElement.");
        }

        public void Remove(IDrawingElement element)
        {
            Console.WriteLine("Cannot remove from a PrimitiveElement.");
        }

        public void Display(int indent)
        {
            Console.WriteLine(new String('-', indent) + " " + _name);
        }
    }
}