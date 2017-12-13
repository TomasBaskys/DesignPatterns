using System;

namespace Observer
{
    public class StockObserver : IObserver
    {
        private double _ibmPrice;
        private double _aaplPrice;
        private double _googPrice;

        private static int observerIDTracker = 0;
        private int _observerID;

        public StockObserver(ISubject stockGrabber)
        {
            _observerID = ++observerIDTracker;

            stockGrabber.Register(this);
            Console.WriteLine($"New observer {_observerID}");
        }

        public void Update(double ibmPrice, double aaplPrice, double googPrice)
        {
            _ibmPrice = ibmPrice;
            _aaplPrice = aaplPrice;
            _googPrice = googPrice;

            Console.WriteLine($"{_observerID} \nIBM: {_ibmPrice} \nAAPL: {_aaplPrice} \nGOOG: {_googPrice} \n");
        }
    }
}