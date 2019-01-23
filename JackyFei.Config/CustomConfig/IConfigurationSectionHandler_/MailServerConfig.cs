using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackyFei.Config.CustomConfig
{
    //mailServerGroup
    public class MailServerConfig : List<MailServer>
    {
        private string provider;    
        public string Provider
        {
            get { return provider; }
            set { provider = value; }
        }
    }
}
