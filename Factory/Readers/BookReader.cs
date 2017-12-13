using System;
using Factory.Books;

namespace Factory.Readers
{
    public abstract class BookReader
    {
        public Book Book;

        public abstract Book BuyBook();

        public Book BuyBook2<T>()
            where T : Book, new()
        {
            return new T();
        }

        protected BookReader()
        {
            Book = BuyBook();
        }

        public void DisplayOwnedBooks()
        {
            Console.WriteLine(Book.GetType().ToString());
        }
    }
}
