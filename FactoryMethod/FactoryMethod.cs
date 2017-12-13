using System;
using System.Collections.Generic;
using FactoryMethod.Books;
using FactoryMethod.Readers;

namespace FactoryMethod
{
    public static class FactoryMethod
    {
        public static void Main()
        {
            var bookReaderList = new List<BookReader>
            {
                new AdventureBookReader(),
                new FantasyBookReader(),
                new HorrorBookReader()
            };

            foreach (var reader in bookReaderList)
            {
                //reader.BuyBook();

                Console.WriteLine(reader.GetType().ToString());

                reader.DisplayOwnedBook();

                Console.WriteLine();
            }

            var genericReader = new AdventureBookReader();
            IBook book = genericReader.BuyBook2<Encyclopedia>();
            Console.WriteLine(book.GetType().ToString());
        }
    }
}