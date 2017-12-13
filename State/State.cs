namespace State
{
    public static class State
    {
        public static void Main()
        {
            var atm = new ATMMachine();

            atm.InsertCard();
            atm.EjectCard();

            atm.InsertCard();
            atm.InsertCard();

            atm.InsertPin(1234);
            atm.RequestCash(150);

            atm.EjectCard();
            atm.InsertCard();
            atm.InsertPin(1234);
        }
    }
}