using System;

namespace Singleton
{
    public class Singleton
    {
        private static int _randomNumber;

        private static Lazy<Singleton> _instance;
        private static readonly Random Random = new Random();

        public static Singleton GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Lazy<Singleton>();
                    Console.WriteLine("Instance initialized");
                    _randomNumber = Random.Next(1, 10);
                }

                return _instance.Value;
            }
        }

        public void DisplayConfiguration()
        {
            Console.WriteLine($"Single instance object. | {_randomNumber}");
        }
    }
}
