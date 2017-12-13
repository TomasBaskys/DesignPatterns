namespace Bridge
{
    public class Bridge
    {
        public static void Main()
        {
            var customers = new Customers("Lithuania")
            {
                Data = new CustomersData()
            };

            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Add("John");

            customers.ShowAll();
        }
    }
}