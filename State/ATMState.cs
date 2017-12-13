namespace State
{
    public interface ATMState
    {
        void InsertCard();

        void EjectCard();

        void InsertPin(int pinCode);

        void RequestCash(int amountToWithdraw);
    }
}
