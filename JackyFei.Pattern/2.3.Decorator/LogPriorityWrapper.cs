using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackyFei.Pattern
{
    public class LogPriorityWrapper : LogWrapper
    {
        public LogPriorityWrapper(Log _log)

            : base(_log)
        {
             
        }

        public override void Write(string log)
        {
            SetPriority(); //......功能扩展
             
            base.Write(log);
        }

        public void SetPriority()
        {
            Console.WriteLine("SetPriority");
            //......实现了记录优先级别
        }

    }
}
