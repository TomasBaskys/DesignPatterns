using Adapter.Connectors;

namespace Adapter
{
    public class Adapter
    {
        public static void Main()
        {
            var tradingDataImporter = new TradingDataImporter();

            var databaseConnector = new DatabaseConnector();
            tradingDataImporter.ImportData(databaseConnector);

            var httpStreamConnector = new HttpStreamConnector();
            tradingDataImporter.ImportData(httpStreamConnector);

            var xmlFileConnector = new XmlFileConnector();
            tradingDataImporter.ImportData(xmlFileConnector);
        }
    }
}