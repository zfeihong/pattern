using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackyFei.Config.Strategy
{
    public class GeneralClass
    {
        private IGreetingStrategy gs;
        public GeneralClass(IGreetingStrategy gs)
        {
            this.gs = gs;
        }
        
        public void SayHello()
        {
            Console.WriteLine(gs.GreetingType);
            Console.WriteLine("\r");
        }
    }
}
