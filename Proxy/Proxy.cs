namespace Proxy
{
    public class Proxy
    {
        public static void Main()
        {
            ICar car1 = new CarProxy(new Driver(16));
            car1.MoveCar();

            ICar car2 = new CarProxy(new Driver(23));
            car2.MoveCar();
        }
    }
}