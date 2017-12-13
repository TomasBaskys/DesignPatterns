using System;

namespace Builder
{
    public enum ComputerType
    {
        Laptop,
        Desktop,
        Apple
    }

    public class Computer
    {
        private readonly ComputerType _computerType;

        public string MotherBoard { get; set; }
        public string Processor { get; set; }
        public string HardDisk { get; set; }
        public string Screen { get; set; }

        public Computer(ComputerType computerType)
        {
            _computerType = computerType;
        }

        public void DisplayConfiguration()
        {
            Console.WriteLine($"Computer: {_computerType}");
            Console.WriteLine($"Computer: {MotherBoard}");
            Console.WriteLine($"Computer: {Processor}");
            Console.WriteLine($"Computer: {HardDisk}");
            Console.WriteLine($"Computer: {Screen}");
        }
    }
}