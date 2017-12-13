using System;
using System.Collections.Generic;

namespace Observer
{
    public class StockGrabber : ISubject
    {
        private readonly IList<IObserver> _observers;

        private double _ibmPrice;
        private double _aaplPrice;
        private double _googPrice;

        public StockGrabber()
        {
            _observers = new List<IObserver>();
        }

        public void Register(IObserver observer)
        {
            _observers.Add(observer);
            Console.WriteLine("Observer added.");
        }

        public void Unregister(IObserver observer)
        {
            int index = _observers.IndexOf(observer);
            _observers.RemoveAt(index);
            Console.WriteLine($"Observer '{index+1}' removed.");
        }

        public void Notify()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(_ibmPrice, _aaplPrice, _googPrice);
            }
        }

        public void SetIbmPrice(double ibmPrice)
        {
            _ibmPrice = ibmPrice;
            Notify();
        }

        public void SetAaplPrice(double aaplPrice)
        {
            _aaplPrice = aaplPrice;
            Notify();
        }

        public void SetGoogPrice(double googPrice)
        {
            _googPrice = googPrice;
            Notify();
        }
    }
}