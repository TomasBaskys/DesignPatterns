using System;

namespace Facade
{
    public class Facade
    {
        public static void Main()
        {
            var customer = new Customer("John");
            var mortgage = new Mortgage();

            bool eligible = mortgage.IsEligible(customer, 125000);

            Console.WriteLine($"\n {customer.Name} has been {(eligible ? "Approved" : "Rejected")}");

            Console.ReadKey();
        }
    }
}