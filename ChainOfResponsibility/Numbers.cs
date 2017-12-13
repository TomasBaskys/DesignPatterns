namespace ChainOfResponsibility
{
    public class Numbers
    {
        public int Number1 { get; private set; }
        public int Number2 { get; private set; }
        public string Action { get; private set; }

        public Numbers(int number1, int number2, string action)
        {
            Number1 = number1;
            Number2 = number2;
            Action = action;
        }
    }
}
