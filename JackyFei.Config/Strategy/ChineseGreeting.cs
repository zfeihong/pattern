using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackyFei.Config.Strategy
{
    // 中文版问候程序
    public class ChineseGreeting : IGreetingStrategy
    {
        public string GreetingType
        {
            get { return "中文问候"; }
        }
    }
}
