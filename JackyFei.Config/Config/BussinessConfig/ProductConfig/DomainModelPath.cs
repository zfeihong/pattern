using System.Xml.Serialization;

namespace JackyFei.Config.Config.BussinessConfig.ProductConfig
{
    public class DomainModelPath
    {
        [XmlAttribute]
        public string Path{ get; set; } 
    }
}