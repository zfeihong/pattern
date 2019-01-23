using System.Xml.Serialization;

namespace JackyFei.Config.Config.BussinessConfig.OrderConfig
{
    public class DistributeArea
    {
        [XmlAttribute]
        public string BeginArea { get; set; }

        [XmlAttribute]
        public string EndArea { get; set; }
         
    }
}