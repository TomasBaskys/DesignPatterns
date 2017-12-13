namespace Composite
{
    public interface IDrawingElement
    {
        void Add(IDrawingElement element);
        void Remove(IDrawingElement element);
        void Display(int indent);
    }
}
