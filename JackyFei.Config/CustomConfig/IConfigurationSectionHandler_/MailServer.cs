using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackyFei.Config.CustomConfig
{
    public class MailServer
    { 
        private Hashtable serverNode;

        public MailServer()
        {
            serverNode = new Hashtable();
        }

        public Hashtable ServerNode
        {
            get { return serverNode; }
        }

        public string Client
        {
            get
            {
                return serverNode["client"] as string;
            }
        }

        public string Address
        {
            get
            {
                return serverNode["address"] as string;
            }
        }

        public string UserName
        {
            get
            {
                return serverNode["userName"] as string;
            }
        }

        public string Password
        {
            get
            {
                return serverNode["password"] as string;
            }
        }
    }
}
