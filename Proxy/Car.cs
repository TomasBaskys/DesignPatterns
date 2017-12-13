using System;

namespace Proxy
{
    public class Car : ICar
    {
        public void MoveCar()
        {
            Console.WriteLine("Car has been driven.");
        }
    }
}