using System;
using FactoryMethod.Books;

namespace FactoryMethod.Readers
{
    public abstract class BookReader
    {
        protected IBook Book;

        //public abstract void BuyBook();

        public IBook BuyBook2<T>()
            where T : IBook, new()
        {
            return new T();
        }

        public void DisplayOwnedBook()
        {
            Console.WriteLine(Book.GetType().ToString());
        }
    }
}
