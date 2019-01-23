using System.Xml.Serialization;

namespace JackyFei.Config.Config.FrameworkConfig.ServerConfig
{
    public class Service
    {
        [XmlAttribute]
        public string Address { get; set; }

        [XmlAttribute]
        public string Timeout{ get; set; } 
    }
}