using Factory.Books;

namespace Factory.Readers
{
    public class AdventureBookReader : BookReader
    {
        public override Book BuyBook()
        {
            return new TreasureIsland();
        }
    }
}