using System.Xml.Serialization;

namespace JackyFei.Config.Config.BussinessConfig.OrderConfig
{
    public class DistributeTime
    {
        [XmlAttribute]
        public string StartTime { get; set; }

        [XmlAttribute]
        public string EndTime { get; set; }

        [XmlAttribute]
        public string DistributeType { get; set; } 
    }
}