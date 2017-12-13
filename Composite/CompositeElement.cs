using System;
using System.Collections.Generic;

namespace Composite
{
    public class CompositeElement : IDrawingElement
    {
        private readonly string _name;
        private readonly List<IDrawingElement> _elements = new List<IDrawingElement>();

        public CompositeElement(string name)
        {
            _name = name;
        }

        public void Add(IDrawingElement element)
        {
            _elements.Add(element);
        }

        public void Remove(IDrawingElement element)
        {
            _elements.Remove(element);
        }

        public void Display(int indent)
        {
            Console.WriteLine($"{new String('-', indent)}+ {_name}");

            foreach (IDrawingElement element in _elements)
            {
                element.Display(indent + 2);
            }
        }
    }
}