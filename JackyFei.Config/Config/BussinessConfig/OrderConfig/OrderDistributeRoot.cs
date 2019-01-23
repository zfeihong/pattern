using System.Collections.Generic;
using System.Xml.Serialization;
using JackyFei.Config.Config.FrameworkConfig.ServerConfig;

namespace JackyFei.Config.Config.BussinessConfig.OrderConfig
{
    [XmlRoot("OrderDistributeRoot")]
    public class OrderDistributeRoot
    {
        [XmlElement("DistributeTime")]
        public DistributeTime DistributeTime { get; set; }

        [XmlElement("DistributeArea")]
        public DistributeArea DistributeArea { get; set; }
    }
}