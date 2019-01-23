using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackyFei.Pattern
{
    public class LogErrorWrapper : LogWrapper
    {
        public LogErrorWrapper(Log _log)

            : base(_log)
        {

        }

        public override void Write(string log)
        {
            SetError(); //......功能扩展

            base.Write(log);
        }

        public void SetError()
        {
            Console.WriteLine("SetError");
            //......实现了记录错误严重级别
        }

    }
}
