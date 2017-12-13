using AbstractFactory.Cars;

namespace AbstractFactory.Factories
{
    public abstract class CarFactory
    {
        public abstract SportsCar CreateSportsCar();

        public abstract FamilyCar CreateFamilyCar();
    }
}