using System;

namespace Bridge
{
    public class Customers : CustomersBase
    {
        public Customers(string group) : base(group)
        {
        }

        public override void ShowAll()
        {
            Console.WriteLine();
            Console.WriteLine(new string('-', 15));
            base.ShowAll();
            Console.WriteLine(new string('-', 15));
        }
    }
}