using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackyFei.Config.Strategy
{
    // 英文版问候程序
    public class EnglishGreeting : IGreetingStrategy
    {
        public string GreetingType
        {
            get { return "English Greeting"; }
        }
    }
}
