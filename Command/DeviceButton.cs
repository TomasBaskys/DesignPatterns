namespace Command
{
    public class DeviceButton
    {
        private readonly ICommand _command;

        public DeviceButton(ICommand command)
        {
            _command = command;
        }

        public void Press()
        {
            _command.Execute();
        }
    }
}