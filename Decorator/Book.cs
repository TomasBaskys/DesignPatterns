using System;

namespace Decorator
{
    public class Book : LibraryItem
    {
        private readonly string _author;
        private readonly string _title;

        public Book(string author, string title, int numCopies)
        {
            _author = author;
            _title = title;
            NumCopies = numCopies;
        }

        public override void Display()
        {
            Console.WriteLine("\nBook --------");
            Console.WriteLine($"Author: {_author}");
            Console.WriteLine($"Title: {_title}");
            Console.WriteLine($" # Copies: {NumCopies}");
        }
    }
}