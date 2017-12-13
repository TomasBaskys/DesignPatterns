namespace Builder.Builders
{
    public class LaptopBuilder : ComputerBuilder
    {
        public LaptopBuilder()
        {
            Computer = new Computer(ComputerType.Laptop);
        }

        public override void BuildMotherboard()
        {
            Computer.MotherBoard = "Laptop Motherboard";
        }

        public override void BuildProcessor()
        {
            Computer.Processor = "Laptop Processor";
        }

        public override void BuildHardDisk()
        {
            Computer.HardDisk = "Laptop HardDisk";
        }

        public override void BuildScreen()
        {
            Computer.Screen = "Laptop Screen";
        }
    }
}