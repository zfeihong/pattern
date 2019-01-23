using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jackyfei.Framework.Fluent
{
    public class RequestProtocol
    {
        private string _protocol;
        public RequestProtocol(string protocol)
        {
            this._protocol = protocol;
        }

        //这里使用约定好的字符串来构造对象，而不是让用户自己去输入协议字符串，防止用户手误导致的异常

        /// <summary>
        /// Webservice2.0公共协议
        /// </summary>
        public const string Soap = "Soap";
        /// <summary>
        /// 内部SOA约定协议
        /// </summary>
        public const string InternalSoa = "Soa";
    }
}
