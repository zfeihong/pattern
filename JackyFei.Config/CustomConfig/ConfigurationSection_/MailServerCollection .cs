using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackyFei.Config.CustomConfig
{
    public sealed class MailServerCollection : ConfigurationElementCollection
    {

        public override ConfigurationElementCollectionType CollectionType
        {
            get { return ConfigurationElementCollectionType.BasicMap; }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new MailServerElement();
        }

        protected override Object GetElementKey(ConfigurationElement element)
        {
            return ((MailServerElement)element).Client;
        }

        protected override string ElementName
        {
            get { return "mailServer"; }
        }

        public new int Count
        {
            get { return base.Count; }
        }


        public MailServerElement this[int index]
        {
            get
            {
                return (MailServerElement)BaseGet(index);
            }
            set
            {
                if (BaseGet(index) != null)
                {
                    BaseRemoveAt(index);
                }
                BaseAdd(index, value);
            }
        }

        new public MailServerElement this[string Name]
        {
            get
            {
                return (MailServerElement)BaseGet(Name);
            }
        }

        public int IndexOf(MailServerElement element)
        {
            return BaseIndexOf(element);
        }

        public void Add(MailServerElement element)
        {
            BaseAdd(element);
        }

        public void Remove(MailServerElement element)
        {
            if (BaseIndexOf(element) >= 0)
                BaseRemove(element.Client);
        }

        public void RemoveAt(int index)
        {
            BaseRemoveAt(index);
        }

        public void Remove(string client)
        {
            BaseRemove(client);
        }

        public void Clear()
        {
            BaseClear();
        }
    }
}
