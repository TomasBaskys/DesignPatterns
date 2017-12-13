namespace ChainOfResponsibility
{
    public class ChainOfResponsibility
    {
        public static void Main()
        {
            var addChain = new AddChain();
            var subChain = new SubChain();
            var multChain = new MultChain();
            var divChain = new DivChain();

            addChain.SetNextChain(subChain);
            subChain.SetNextChain(multChain);
            multChain.SetNextChain(divChain);

            Numbers numbers1 = new Numbers(6, 3, "add");
            Numbers numbers2 = new Numbers(6, 3, "sub");
            Numbers numbers3 = new Numbers(6, 3, "mult");
            Numbers numbers4 = new Numbers(6, 3, "div");
            Numbers numbers5 = new Numbers(6, 3, "pow");

            addChain.Calculate(numbers1);
            addChain.Calculate(numbers2);
            addChain.Calculate(numbers3);
            addChain.Calculate(numbers4);
            addChain.Calculate(numbers5);
        }
    }
}