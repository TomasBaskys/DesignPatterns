namespace Template
{
    public static class Template
    {
        public static void Main()
        {
            var cust12Order = new ItalianHoagie();
            cust12Order.MakeSandwich();

            var cust13Order = new VeggieHoagie();
            cust13Order.MakeSandwich();
        }
    }
}