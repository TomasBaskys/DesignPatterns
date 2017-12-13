using Factory.Books;

namespace Factory.Readers
{
    public class HorrorBookReader : BookReader
    {
        public override Book BuyBook()
        {
            return new Dracula();
        }
    }
}