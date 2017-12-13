using Builder.Builders;

namespace Builder
{
    public static class Builder
    {
        public static void Main()
        {
            ComputerShop shop = new ComputerShop();

            ComputerBuilder builder;

            builder = new LaptopBuilder();
            shop.ConstructComputer(builder);
            builder.Computer.DisplayConfiguration();

            builder = new DesktopBuilder();
            shop.ConstructComputer(builder);
            builder.Computer.DisplayConfiguration();

            builder = new AppleBuilder();
            shop.ConstructComputer(builder);
            builder.Computer.DisplayConfiguration();
        }
    }
}
