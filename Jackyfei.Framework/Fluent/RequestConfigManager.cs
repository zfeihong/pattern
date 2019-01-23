using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jackyfei.Framework.Fluent
{
    /// <summary>
    /// 一、非扩展方法实现链式编程模式
    /// 相对扩展方法的缺点是硬编码，其次发布后修改麻烦
    /// </summary>
    public class RequestConfigManager
    {
        /// <summary>
        /// 使用单例模式的请求上下文对象
        /// </summary>
        public static RequestConfigManager GlobalConfig = new RequestConfigManager();

        /// <summary>
        /// 使用方法代替手动输入字符串，别相信你的框架使用者有多么清醒
        /// </summary>
        /// <returns></returns>
        public RequestConfigManager SetGlobalRequestFormatJson()
        {
            if (string.IsNullOrEmpty(RequestConfigContext.ConfigContext.Format))
                RequestConfigContext.ConfigContext.Format = "json";
            return this;
        }

        public RequestConfigManager SetGlobalRequestFormatXml()
        {
            if (string.IsNullOrEmpty(RequestConfigContext.ConfigContext.Format))
                RequestConfigContext.ConfigContext.Format = "xml";
            return this;
        }
        public RequestConfigManager SetGlobalRequestProtocol(RequestProtocol protocol)
        {
            RequestConfigContext.ConfigContext.Protocol = protocol;
            return this;
        }
        public RequestConfigManager SetGlobalRequestSize(int size)
        {
            RequestConfigContext.ConfigContext.Size = size;
            return this;
        }
    }

}
