namespace Mediator
{
    public class Mediator
    {
        public static void Main()
        {
            var mediator = new StockMediator();

            var broker1 = new JerseyColleague(mediator);
            var broker2 = new SparkColleague(mediator);

            broker1.SaleOffer("GOOG", 100);
            broker1.SaleOffer("APPL", 30);

            broker2.BuyOffer("APPL", 30);
            broker2.BuyOffer("NTG", 50);
            broker2.SaleOffer("HP", 10);

            broker1.BuyOffer("HP", 10);
            broker1.SaleOffer("NTG", 50);
            broker2.BuyOffer("NTG", 50);

            mediator.GetStockStatus();
        }
    }
}