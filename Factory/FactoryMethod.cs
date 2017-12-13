using System;
using System.Collections.Generic;
using Factory.Books;
using Factory.Readers;

namespace Factory
{
    public static class FactoryMethod
    {
        public static void Factory()
        {
            var bookReaderList = new List<BookReader>
            {
                new AdventureBookReader(),
                new FantasyBookReader(),
                new HorrorBookReader()
            };

            foreach (var reader in bookReaderList)
            {
                Console.WriteLine(reader.GetType().ToString());

                reader.DisplayOwnedBooks();

                Console.WriteLine();
            }

            var genericReader = new AdventureBookReader();
            Book book = genericReader.BuyBook2<Encyclopedia>();
            Console.WriteLine(book.GetType().ToString());

            Console.ReadLine();
        }
    }
}