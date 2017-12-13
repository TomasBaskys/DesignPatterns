using System;

namespace State
{
    public class NoCard : ATMState
    {
        private readonly ATMMachine _atm;

        public NoCard(ATMMachine atm)
        {
            _atm = atm;
        }

        public void InsertCard()
        {
            Console.WriteLine("Card Inserter");
            _atm.SetATMState(_atm.HasCard);
        }

        public void EjectCard()
        {
            Console.WriteLine("Insert card first");
        }

        public void InsertPin(int pinCode)
        {
            Console.WriteLine("Insert card first");
        }

        public void RequestCash(int amountToWithdraw)
        {
            Console.WriteLine("Insert card first");
        }
    }
}