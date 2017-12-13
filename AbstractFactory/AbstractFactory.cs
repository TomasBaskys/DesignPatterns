using System;
using AbstractFactory.Cars;
using AbstractFactory.Factories;

namespace AbstractFactory
{
    public static class AbstractFactory
    {
        public static void Main()
        {
            var audiFactory = new AudiFactory();
            var audiDriver = new Driver(audiFactory);
            audiDriver.CompareSpeed();

            var mercedesFactory = new MercedesFactory();
            var mercedesDriver = new Driver(mercedesFactory);
            mercedesDriver.CompareSpeed();

            var factory = new GenericFactory<AudiSportsCar>();
            AudiSportsCar audiSportsCar = factory.CreateObject();
            Console.WriteLine(audiSportsCar.GetType().ToString());

            Console.ReadLine();
        }
    }
}