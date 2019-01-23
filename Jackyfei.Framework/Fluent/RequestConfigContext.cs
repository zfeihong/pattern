using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jackyfei.Framework.Fluent
{
    public class RequestConfigContext
    {
        /// <summary>
        /// 全局设置上下文实例
        /// </summary>
        public static RequestConfigContext ConfigContext = new RequestConfigContext();
        public string Format { get; set; }
        public int Size { get; set; }
        public RequestProtocol Protocol { get; set; }
        public string Content { get; set; }

        public Func<RequestContext, bool> SaftyCheck { get; set; }
    }
}
