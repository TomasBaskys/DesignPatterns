using System;
using System.Collections.Generic;

namespace Decorator
{
    public class Borrowable : Decorator
    {
        private readonly List<string> _borrowers = new List<string>();

        public Borrowable(LibraryItem libraryItem) : base(libraryItem)
        {
        }

        public void BorrowItem(string name)
        {
            _borrowers.Add(name);
            _libraryItem.NumCopies--;
        }

        public void ReturnItem(string name)
        {
            _borrowers.Remove(name);
            _libraryItem.NumCopies++;
        }

        public override void Display()
        {
            base.Display();

            foreach (string borrower in _borrowers)
            {
                Console.WriteLine($" borrower: {borrower}");
            }
        }
    }
}