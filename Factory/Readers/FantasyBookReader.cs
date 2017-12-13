using Factory.Books;

namespace Factory.Readers
{
    public class FantasyBookReader : BookReader
    {
        public override Book BuyBook()
        {
            return new LordOfTheRings();
        }
    }
}