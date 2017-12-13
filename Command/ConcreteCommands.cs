namespace Command
{
    #region Turn ON

    public class TurnOn : ICommand
    {
        private readonly IElectronicDevice _device;

        public TurnOn(IElectronicDevice device)
        {
            _device = device;
        }

        public void Execute()
        {
            _device.TurnOn();
        }
    }

    #endregion

    #region Turn OFF

    public class TurnOff : ICommand
    {
        private readonly IElectronicDevice _device;

        public TurnOff(IElectronicDevice device)
        {
            _device = device;
        }

        public void Execute()
        {
            _device.TurnOff();
        }
    }

    #endregion

    #region Turn Volume UP

    public class TurnUp : ICommand
    {
        private readonly IElectronicDevice _device;

        public TurnUp(IElectronicDevice device)
        {
            _device = device;
        }

        public void Execute()
        {
            _device.VolumeUp();
        }
    }

    #endregion

    #region Turn Volume Down

    public class TurnDown : ICommand
    {
        private readonly IElectronicDevice _device;

        public TurnDown(IElectronicDevice device)
        {
            _device = device;
        }

        public void Execute()
        {
            _device.VolumeDown();
        }
    }

    #endregion
}