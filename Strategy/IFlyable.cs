namespace Strategy
{
    public interface IFlyable
    {
        string Fly();
    }

    public class CanFly : IFlyable
    {
        public string Fly()
        {
            return "Fly High!";
        }
    }

    public class CannotFly : IFlyable
    {
        public string Fly()
        {
            return "Can't Fly...";
        }
    }
}