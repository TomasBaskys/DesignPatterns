using System;

namespace AbstractFactory.Cars
{
    public class MercedesSportsCar : SportsCar
    {
    }

    public class MercedesFamilyCar : FamilyCar
    {
        public override void Speed(SportsCar sportsCar)
        {
            Console.WriteLine($"{this.GetType().Name} is slower than {sportsCar.GetType().Name}");
        }
    }
}