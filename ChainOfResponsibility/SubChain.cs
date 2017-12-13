using System;

namespace ChainOfResponsibility
{
    public class SubChain : IChain
    {
        private IChain _nextChain;

        public void SetNextChain(IChain nextChain)
        {
            _nextChain = nextChain;
        }

        public void Calculate(Numbers numbers)
        {
            if (numbers.Action.Equals("sub"))
            {
                int result = numbers.Number1 - numbers.Number2;

                Console.WriteLine($"{numbers.Number1} - {numbers.Number2} = {result}");
            }
            else
            {
                _nextChain.Calculate(numbers);
            }
        }
    }
}