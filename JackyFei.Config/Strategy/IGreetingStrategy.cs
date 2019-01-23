using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackyFei.Config.Strategy
{
    public interface IGreetingStrategy
    {
        string GreetingType { get; }
    }
}
