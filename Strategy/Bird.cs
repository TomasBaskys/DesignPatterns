namespace Strategy
{
    public class Bird : Animal
    {
        public Bird()
        {
            _flyType = new CanFly();
        }
    }
}