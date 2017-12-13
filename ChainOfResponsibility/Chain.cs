namespace ChainOfResponsibility
{
    public interface IChain
    {
        void SetNextChain(IChain nextChain);

        void Calculate(Numbers numbers);
    }
}