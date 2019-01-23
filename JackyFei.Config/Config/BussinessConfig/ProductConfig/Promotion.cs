using System.Xml.Serialization;

namespace JackyFei.Config.Config.BussinessConfig.ProductConfig
{
    public class Promotion
    {
        [XmlElement]
        public DomainModelPath DomainModelPath { get; set; } 
    }
}