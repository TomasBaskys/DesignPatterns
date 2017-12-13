using System;

namespace State
{
    public class HasCard : ATMState
    {
        private readonly ATMMachine _atm;

        public HasCard(ATMMachine atm)
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
            if (pinCode == 1234)
            {
                Console.WriteLine("Correct PIN");
                _atm.CorrectPinEntered = true;
                _atm.SetATMState(_atm.HasCorrectPin);
            }
            else
            {
                Console.WriteLine("Wrong PIN");
                _atm.CorrectPinEntered = false;
                Console.WriteLine("Card Ejected");
                _atm.SetATMState(_atm.NoCard);
            }
        }

        public void RequestCash(int amountToWithdraw)
        {
            Console.WriteLine("Enter PIN first!");
        }
    }
}