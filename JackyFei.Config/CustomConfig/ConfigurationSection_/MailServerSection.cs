using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackyFei.Config.CustomConfig
{
    public class MailServerSection : ConfigurationSection
    {

        [ConfigurationProperty("provider", IsKey = true)]
        public string Provider
        {
            get { return this["provider"] as string; }
        }

        [ConfigurationProperty("mailServers", IsDefaultCollection = false)]
        public MailServerCollection MailServers
        {
            get
            {
                return (MailServerCollection)this["mailServers"];
            }
            set
            {
                this["mailServers"] = value;
            }
        }
    }
}
