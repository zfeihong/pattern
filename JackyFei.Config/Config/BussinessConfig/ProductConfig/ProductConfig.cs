using System.Collections.Generic;
using System.Xml.Serialization;

namespace JackyFei.Config.Config.BussinessConfig.ProductConfig
{
    [XmlRoot("ProductConfig")]
    public class ProductConfig
    {
        [XmlElement("Promotion")]
        public List<Promotion> Promotions{ get; set; }
    }
}