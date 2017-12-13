namespace Command
{
    public static class Command
    {
        public static void Main()
        {
            ICommand command;
            IElectronicDevice device;
            DeviceButton button;

            device = new Television();

            command = new TurnOn(device);
            button = new DeviceButton(command);
            button.Press();

            command = new TurnOff(device);
            button = new DeviceButton(command);
            button.Press();

            command = new TurnUp(device);
            button = new DeviceButton(command);
            button.Press();
            button.Press();
            button.Press();

            command = new TurnDown(device);
            button = new DeviceButton(command);
            button.Press();

            // -----------------------------------

            device = new Radio();

            command = new TurnOn(device);
            button = new DeviceButton(command);
            button.Press();

            command = new TurnOff(device);
            button = new DeviceButton(command);
            button.Press();

            command = new TurnUp(device);
            button = new DeviceButton(command);
            button.Press();
            button.Press();
            button.Press();

            command = new TurnDown(device);
            button = new DeviceButton(command);
            button.Press();
        }
    }
}