using System;

namespace State
{
    public class NoCash : ATMState
    {
        public NoCash(ATMMachine atm)
        {
        }

        public void InsertCard()
        {
            Console.WriteLine("We don't have money");
        }

        public void EjectCard()
        {
            Console.WriteLine("We don't have money. You didn't enter the card");
        }

        public void InsertPin(int pinCode)
        {
            Console.WriteLine("We don't have money");
        }

        public void RequestCash(int amountToWithdraw)
        {
            Console.WriteLine("We don't have money");
        }
    }
}