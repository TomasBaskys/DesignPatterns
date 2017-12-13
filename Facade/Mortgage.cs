using System;

namespace Facade
{
    public class Mortgage
    {
        private readonly Bank _bank = new Bank();
        private readonly Credit _credit = new Credit();
        private readonly Loan _loan = new Loan();

        public bool IsEligible(Customer customer, int amount)
        {
            Console.WriteLine($"{customer.Name} applies for {amount} loan\n");

            bool isEligible = true;

            if (!_bank.HasSufficientSavings(customer, amount))
            {
                isEligible = false;
            }
            else if (!_credit.HasGoodCredit(customer))
            {
                isEligible = false;
            }
            else if (!_loan.HasNoBadLoans(customer))
            {
                isEligible = false;
            }

            return isEligible;
        }
    }
}
