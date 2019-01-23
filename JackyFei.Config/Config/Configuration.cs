using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JackyFei.Config.Config.BussinessConfig.OrderConfig;
using JackyFei.Config.Config.BussinessConfig.ProductConfig;
using JackyFei.Config.Config.FrameworkConfig.ServiceConfig;

namespace JackyFei.Config.Config
{
    public class Configuration
    {
        public static Configuration ConfigurationManager=ConfigurationFactory.Create();

        public ServiceConfig ServiceConfig { get; set; }
        public ProductConfig ProductConfig { get; set; }
        public OrderDistributeRoot OrderConfig { get; set; }
    }
}
