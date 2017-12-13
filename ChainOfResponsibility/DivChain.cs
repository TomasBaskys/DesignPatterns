using System;

namespace ChainOfResponsibility
{
    public class DivChain : IChain
    {
        private IChain _nextChain;

        public void SetNextChain(IChain nextChain)
        {
            _nextChain = nextChain;
        }

        public void Calculate(Numbers numbers)
        {
            if (numbers.Action.Equals("div"))
            {
                int result = numbers.Number1 / numbers.Number2;

                Console.WriteLine($"{numbers.Number1} / {numbers.Number2} = {result}");
            }
            else
            {
                Console.WriteLine("Available actions: add, sub, mult and div.");
            }
        }
    }
}