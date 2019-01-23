using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace JackyFei.Config.ManagerConfig
{
    public class ConfigManager
    {
        private XmlNode section;
        private ForumConfiguration forumConfig;

        // private BlogConfiguration blogConfig;
        // private MailServerConfiguration mailServerConfig;
        // private IGreetingStrategy greetingStrategy;
        // 以下类似，省略 ...

        public ForumConfiguration ForumConfig
        {
            get { return forumConfig; }
        }

        //public BlogConfiguration BlogConfig {
        //  get { return blogConfig; }
        //} 以下类似，省略 ...

        public ConfigManager(XmlNode section)
        {
            this.section = section;

            forumConfig = new ForumConfiguration(section.SelectSingleNode("forum"));

            // blogConfig = new BlogConfiguration(section.SelectSingleNode("blog"));
            // mailServerConfig = new MailServerConfiguration(section.SelectSingleNode("mailServer"));
            // 以下类似，省略 ...
        }
    }
}
