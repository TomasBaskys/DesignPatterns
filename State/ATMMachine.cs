namespace State
{
    public class ATMMachine
    {
        public int CashInMachine = 2000;
        public bool CorrectPinEntered = false;

        public ATMState HasCard { get; private set; }
        public ATMState NoCard { get; private set; }
        public ATMState HasCorrectPin { get; private set; }
        public ATMState AtmOutOfMoney { get; private set; }
        public ATMState AtmState { get; private set; }

        public ATMMachine()
        {
            HasCard = new HasCard(this);
            NoCard = new NoCard(this);
            HasCorrectPin = new HasPin(this);
            AtmOutOfMoney = new NoCash(this);

            AtmState = NoCard;

            if (CashInMachine < 0)
            {
                AtmState = AtmOutOfMoney;
            }
        }

        public void SetATMState(ATMState state)
        {
            AtmState = state;
        }

        public void SetMoneyAmountInATM(int amount)
        {
            CashInMachine = amount;
        }

        public void InsertCard()
        {
            AtmState.InsertCard();
        }

        public void EjectCard()
        {
            AtmState.EjectCard();
        }

        public void InsertPin(int pinCode)
        {
            AtmState.InsertPin(pinCode);
        }

        public void RequestCash(int amount)
        {
            AtmState.RequestCash(amount);
        }
    }
}