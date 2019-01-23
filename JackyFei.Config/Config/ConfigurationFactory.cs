using System;
using System.IO;
using System.Xml.Serialization;
using JackyFei.Config.Config.BussinessConfig.OrderConfig;
using JackyFei.Config.Config.BussinessConfig.ProductConfig;
using JackyFei.Config.Config.FrameworkConfig.ServiceConfig;

namespace JackyFei.Config.Config
{
    public class ConfigurationFactory
    {
        private static readonly string ProductConfigPath;

        private static readonly string ServiceConfigPath;

        private static readonly string OrderConfigPath;

        static ConfigurationFactory()
        {
            ProductConfigPath = string.Format("{0}{1}", AppDomain.CurrentDomain.BaseDirectory, @"Config\BussinessConfig\ProductConfig\Product.xml");
            ServiceConfigPath = string.Format("{0}{1}", AppDomain.CurrentDomain.BaseDirectory, @"Config\FrameworkConfig\ServiceConfig\Service.xml");
            OrderConfigPath = string.Format("{0}{1}", AppDomain.CurrentDomain.BaseDirectory, @"Config\BussinessConfig\OrderConfig\OrderDistribute.xml");
        }

        public static Configuration Create()
        {
            return new Configuration()
            {
                ProductConfig = CreateProductConfig(),
                ServiceConfig = CreateServerConfig(),
                OrderConfig = CreateOrderConfig()
            };
        }

        public static ProductConfig CreateProductConfig()
        {
            using (FileStream fileStream=new FileStream(ProductConfigPath,FileMode.OpenOrCreate,FileAccess.ReadWrite))
            {
                XmlSerializer sz=new XmlSerializer(typeof(ProductConfig));
                return sz.Deserialize(fileStream) as ProductConfig;
            }
        }

        public static ServiceConfig CreateServerConfig()
        {
            using (FileStream fileStream = new FileStream(ServiceConfigPath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                XmlSerializer sz = new XmlSerializer(typeof(ServiceConfig));
                return sz.Deserialize(fileStream) as ServiceConfig;
            }
        }

        public static OrderDistributeRoot CreateOrderConfig()
        {
            using (FileStream fileStream = new FileStream(OrderConfigPath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                XmlSerializer sz = new XmlSerializer(typeof(OrderDistributeRoot));
                return sz.Deserialize(fileStream) as OrderDistributeRoot;
            }
        }
    }
}