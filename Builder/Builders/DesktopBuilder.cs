namespace Builder.Builders
{
    public class DesktopBuilder : ComputerBuilder
    {
        public DesktopBuilder()
        {
            Computer = new Computer(ComputerType.Desktop);
        }

        public override void BuildMotherboard()
        {
            Computer.MotherBoard = "Desktop Motherboard";
        }

        public override void BuildProcessor()
        {
            Computer.Processor = "Desktop Processor";
        }

        public override void BuildHardDisk()
        {
            Computer.HardDisk = "Desktop HardDisk";
        }

        public override void BuildScreen()
        {
            Computer.Screen = "Desktop Screen";
        }
    }
}