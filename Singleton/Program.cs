namespace Singleton
{
    public class Program
    {
        public static void Main()
        {
            var singleton = Singleton.GetInstance;
            singleton.DisplayConfiguration();

            var singleton2 = Singleton.GetInstance;
            singleton2.DisplayConfiguration();
        }
    }
}