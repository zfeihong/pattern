using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace JackyFei.Config.CustomConfig
{
    public class MailServerConfigurationHandler : IConfigurationSectionHandler
    {
        public object Create(object parent, object configContext, XmlNode section)
        {
            MailServerConfig config = new MailServerConfig();

            config.Provider = section.Attributes["provider"] == null ? "" : section.Attributes["provider"].Value;

            foreach (XmlNode child in section.ChildNodes)
            {
                MailServer server = new MailServer();

                if (child.Attributes["client"] != null)
                    server.ServerNode.Add("client", child.Attributes["client"].Value);

                foreach (XmlNode grandChild in child.ChildNodes)
                {
                    server.ServerNode.Add(grandChild.Name, grandChild.InnerText);
                }
                config.Add(server);
            }
            return config;
        }
    }
}
