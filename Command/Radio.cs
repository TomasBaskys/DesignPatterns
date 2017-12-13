using System;

namespace Command
{
    public class Radio : IElectronicDevice
    {
        private int _volume = 0;

        public void TurnOn()
        {
            Console.WriteLine("Radio is ON");
        }

        public void TurnOff()
        {
            Console.WriteLine("Radio is OFF");
        }

        public void VolumeUp()
        {
            Console.WriteLine($"Radio volume is {++_volume}");
        }

        public void VolumeDown()
        {
            Console.WriteLine($"Radio volume is {--_volume}");
        }
    }
}