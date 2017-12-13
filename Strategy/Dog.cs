namespace Strategy
{
    public class Dog : Animal
    {
        public Dog()
        {
            _flyType = new CannotFly();
        }
    }
}