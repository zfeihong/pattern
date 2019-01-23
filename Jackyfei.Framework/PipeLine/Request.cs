using System.Text;

namespace Jackyfei.Framework.PipeLine
{
    /// <summary>
    /// 以Request为聚合根的管道基础对象创建
    /// </summary>
    public class Request
    {
        /// <summary>
        /// 请求头
        /// </summary>
        public StringBuilder Head{ get; set; }
        /// <summary>
        /// 请求类别
        /// </summary>
        public RequestClientType ClientType { get; set; }

        public RequestContent Content{ get; set; }

    }

}