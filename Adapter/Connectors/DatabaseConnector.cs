using Adapter.ThirdPartyLibs;

namespace Adapter.Connectors
{
    public class DatabaseConnector : IConnector
    {
        public void GetData()
        {
            var databaseHelper = new DatabaseHelper();
            databaseHelper.QueryForChanges();
        }
    }
}