namespace Observer
{
    public static class Observer
    {
        public static void Main()
        {
            var stockGrabber = new StockGrabber();

            var observer1 = new StockObserver(stockGrabber);

            stockGrabber.SetIbmPrice(154.40);
            stockGrabber.SetAaplPrice(651.10);
            stockGrabber.SetGoogPrice(321.11);

            var observer2 = new StockObserver(stockGrabber);

            stockGrabber.SetIbmPrice(154.40);
            stockGrabber.SetAaplPrice(651.10);
            stockGrabber.SetGoogPrice(321.11);

            stockGrabber.Unregister(observer1);

            stockGrabber.SetIbmPrice(154.40);
            stockGrabber.SetAaplPrice(651.10);
            stockGrabber.SetGoogPrice(321.11);
        }
    }
}