using System;

namespace Command
{
    public class Television : IElectronicDevice
    {
        private int _volume = 0;

        public void TurnOn()
        {
            Console.WriteLine("TV is ON");
        }

        public void TurnOff()
        {
            Console.WriteLine("TV is OFF");
        }

        public void VolumeUp()
        {
            Console.WriteLine($"TV volume is {++_volume}");
        }

        public void VolumeDown()
        {
            Console.WriteLine($"TV volume is {--_volume}");
        }
    }
}