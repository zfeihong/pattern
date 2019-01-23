using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace JackyFei.Config.ManagerConfig
{
    public class ForumConfiguration
    {
        private XmlNode forumNode;

        public ForumConfiguration(XmlNode section)
        {
            this.forumNode = section;
        }

        public string Name
        {
            get { return forumNode.Attributes["name"].Value; }
        }

        public string RootUrl
        {
            get { return forumNode.SelectSingleNode("root").Attributes["url"].Value; }
        }

        public int PageSize
        {
            get { return int.Parse(forumNode.SelectSingleNode("pageSize").InnerText); }
        }

        public int ReplyCount
        {
            get { return int.Parse(forumNode.SelectSingleNode("replyCount").InnerText); }
        }

        public int OfflineTime
        {
            get { return int.Parse(forumNode.SelectSingleNode("offlineTime").InnerText); }
        }
    }
}
