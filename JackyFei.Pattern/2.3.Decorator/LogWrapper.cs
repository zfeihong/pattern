using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackyFei.Pattern
{
    public abstract class LogWrapper : Log
    {
        private Log _log;

        public LogWrapper(Log log)
        {
            _log = log;
        }

        public override void Write(string log)
        {
            Console.WriteLine(log);
            _log.Write(log);
        }

    }
}
