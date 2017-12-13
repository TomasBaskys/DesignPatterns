using System;

namespace State
{
    public class HasPin : ATMState
    {
        private readonly ATMMachine _atm;

        public HasPin(ATMMachine atm)
        {
            _atm = atm;
        }

        public void InsertCard()
        {
            Console.WriteLine("You can't enter more than one card.");
        }

        public void EjectCard()
        {
            Console.WriteLine("Card ejected.");
            _atm.SetATMState(_atm.NoCard);
        }

        public void InsertPin(int pinCode)
        {
            Console.WriteLine("PIN is already inserted");

        }

        public void RequestCash(int amountToWithdraw)
        {
            if (amountToWithdraw > _atm.CashInMachine)
            {
                Console.WriteLine("Don't have that cash");
                Console.WriteLine("Card Ejected");
                _atm.SetATMState(_atm.NoCard);
            }
            else
            {
                Console.WriteLine($"{amountToWithdraw} is provided by the machine");
                _atm.SetMoneyAmountInATM(_atm.CashInMachine - amountToWithdraw);

                Console.WriteLine("Card Ejected");
                _atm.SetATMState(_atm.NoCard);

                if (_atm.CashInMachine <= 0)
                {
                    _atm.SetATMState(_atm.AtmOutOfMoney);
                }
            }
        }
    }
}