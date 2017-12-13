using System;

namespace Strategy
{
    public class Strategy
    {
        public static void Main()
        {
            var dog = new Dog();
            var bird = new Bird();

            Console.WriteLine($"Dog: {dog.GetFlyType()}");
            Console.WriteLine($"Bird: {bird.GetFlyType()}");

            dog.SetFlyType(new CanFly());
            Console.WriteLine($"Dog: {dog.GetFlyType()}");
        }
    }
}