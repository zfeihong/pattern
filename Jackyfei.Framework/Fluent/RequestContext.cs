using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jackyfei.Framework.Fluent
{
    public class RequestContext
    { 
        public string Format { get; set; }
        public int Size { get; set; }
        public RequestProtocol Protocol { get; set; }
        public string Content { get; set; }
    }
}
