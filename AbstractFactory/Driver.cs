using System;
using AbstractFactory.Cars;
using AbstractFactory.Factories;

namespace AbstractFactory
{
    public class Driver
    {
        private readonly SportsCar _sportsCar;

        private readonly FamilyCar _familyCar;

        public Driver(CarFactory carFactory)
        {
            if (carFactory == null)
                throw new ArgumentNullException(nameof(carFactory));

            _sportsCar = carFactory.CreateSportsCar();
            _familyCar = carFactory.CreateFamilyCar();
        }

        public void CompareSpeed()
        {
            _familyCar.Speed(_sportsCar);
        }
    }
}
