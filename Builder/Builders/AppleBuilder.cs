namespace Builder.Builders
{
    public class AppleBuilder : ComputerBuilder
    {
        public AppleBuilder()
        {
            Computer = new Computer(ComputerType.Apple);
        }

        public override void BuildMotherboard()
        {
            Computer.MotherBoard = "Apple Motherboard";
        }

        public override void BuildProcessor()
        {
            Computer.Processor = "Apple Processor";
        }

        public override void BuildHardDisk()
        {
            Computer.HardDisk = "Apple HardDisk";
        }

        public override void BuildScreen()
        {
            Computer.Screen = "Apple Screen";
        }
    }
}