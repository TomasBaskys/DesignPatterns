using Adapter.Connectors;

namespace Adapter
{
    public class TradingDataImporter
    {
        public void ImportData(IConnector connector)
        {
            connector.GetData();
        }
    }
}
