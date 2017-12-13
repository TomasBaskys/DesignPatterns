namespace Command
{
    public interface IElectronicDevice
    {
        void TurnOn();

        void TurnOff();

        void VolumeUp();

        void VolumeDown();
    }
}