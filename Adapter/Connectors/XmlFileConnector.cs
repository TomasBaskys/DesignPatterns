using Adapter.ThirdPartyLibs;

namespace Adapter.Connectors
{
    public class XmlFileConnector : IConnector
    {
        public void GetData()
        {
            var xmlFileLoader = new XmlFileLoader();
            xmlFileLoader.LoadXML();
        }
    }
}