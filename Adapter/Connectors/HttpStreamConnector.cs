using Adapter.ThirdPartyLibs;

namespace Adapter.Connectors
{
    public class HttpStreamConnector : IConnector
    {
        public void GetData()
        {
            var websiteScanner = new WebsiteScanner();
            websiteScanner.Scan();
        }
    }
}