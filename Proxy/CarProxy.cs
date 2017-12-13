using System;

namespace Proxy
{
    public class CarProxy : ICar
    {
        private readonly Driver _driver;
        private readonly ICar _realCar;

        public CarProxy(Driver driver)
        {
            _driver = driver;
            _realCar = new Car();
        }

        public void MoveCar()
        {
            if (_driver.Age <= 16)
            {
                Console.WriteLine("Sorry the driver is too young to drive.");
            }
            else
            {
                _realCar.MoveCar();
            }
        }
    }
}