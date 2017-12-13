using System;

namespace AbstractFactory.Cars
{
    public class AudiSportsCar : SportsCar
    {
    }

    public class AudiFamilyCar : FamilyCar
    {
        public override void Speed(SportsCar sportsCar)
        {
            Console.WriteLine($"{this.GetType().Name} is slower than {sportsCar.GetType().Name}");
        }
    }
}