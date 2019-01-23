using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackyFei.Config.CustomConfig
{
    public sealed class MailServerElement : ConfigurationElement
    {

        [ConfigurationProperty("client", IsKey = true, IsRequired = true)]
        public string Client
        {
            get { return this["client"] as string; }
            set { this["client"] = value; }
        }

        [ConfigurationProperty("address")]
        public string Address
        {
            get { return this["address"] as string; }
            set { this["client"] = value; }
        }

        [ConfigurationProperty("userName")]
        public string UserName
        {
            get { return this["userName"] as string; }
            set { this["client"] = value; }
        }

        [ConfigurationProperty("password")]
        public string Password
        {
            get { return this["password"] as string; }
            set { this["client"] = value; }
        }
    }

}
