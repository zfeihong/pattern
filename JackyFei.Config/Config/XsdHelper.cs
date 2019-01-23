using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace JackyFei.Config.Config
{
    class XsdHelper
    {
        public static void XmlValidationByXsd(string xmlFile, string xsdFile, string namespaceUrl = null)
        {
            xmlFile = AppDomain.CurrentDomain.BaseDirectory + "\\Config\\BussinessConfig\\OrderConfig\\OrderDistribute.xml";
            xsdFile = AppDomain.CurrentDomain.BaseDirectory + "\\Config\\BussinessConfig\\OrderConfig\\OrderDistribute.xsd";

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.DtdProcessing = DtdProcessing.Parse;
            settings.ValidationType = ValidationType.Schema;
            settings.Schemas.Add(namespaceUrl, xsdFile);
            settings.ValidationEventHandler += (x, y) =>
            {
                Console.WriteLine("line:{0},column:{1},Error:{2}",y.Exception.LineNumber,y.Exception.LinePosition,y.Exception.Message);
            };

            using (XmlReader reader = XmlReader.Create(xmlFile, settings))
            {
                try
                {
                    while (reader.Read())
                    {
                    }
                    Console.WriteLine("验证成功！");
                }
                catch (XmlException ex)
                {
                    Console.WriteLine("异常!");
                }
            }
        }  
    }
}
