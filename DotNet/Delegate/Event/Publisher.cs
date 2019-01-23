using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Delegate.Event
{
    public delegate string GeneralEventHandler();

    public delegate string DemoEventHandler(int num);

    public class Publisher
    {
        private GeneralEventHandler numberChanged;
        public event GeneralEventHandler NumberChanged
        {
            add { numberChanged = value; }
            remove { numberChanged -= value; }
        }

        public event DemoEventHandler NumberChanged2;

        public List<string> DoSomething2()
        {
            List<string> strList=new List<string>();
            if (NumberChanged2 == null) return strList;

            System.Delegate[] delegates = NumberChanged2.GetInvocationList();
            foreach (System.Delegate del in delegates)
            {
                DemoEventHandler meth = (DemoEventHandler) del;
                try
                {
                    object obj = del.DynamicInvoke(100);
                    strList.Add(obj.ToString());
                    //strList.Add(meth(100));
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return strList;
        }

        public void DoSomething()
        {
            if (numberChanged!=null)
            {
                string rtn = numberChanged();
                Console.WriteLine("Return {0}",rtn);
            }
        }
    }
}
