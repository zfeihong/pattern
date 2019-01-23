using System.Collections.Generic;
using System.Xml.Serialization;
using JackyFei.Config.Config.FrameworkConfig.ServerConfig;

namespace JackyFei.Config.Config.FrameworkConfig.ServiceConfig
{
    [XmlRoot("ServiceConfig")]
    public class ServiceConfig
    {
        [XmlElement("Service")]
        public List<Service> Services { get; set; }
    }
}