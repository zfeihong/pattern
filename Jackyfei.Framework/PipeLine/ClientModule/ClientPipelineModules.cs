using System;

namespace Jackyfei.Framework.PipeLine.ClientModule
{
    /// <summary>
    /// 客户端Modules
    /// </summary>
    public class ClientPipelineModules
    {
        /// <summary>
        /// 验证请求正文
        /// </summary>
        /// <param name="request"></param>
        public static void CheckRequestContent(Request request)
        {
            if (request==null||request.Content==null||string.IsNullOrEmpty(request.Content.Content))
            {
                throw new InvalidOperationException();
            }
        }
        /// <summary>
        /// 添加请求头部
        /// </summary>
        public static void AddRequestHead(Request request)
        {
            request.Head.Append("Request source:SOA Client");
        }

        /// <summary>
        /// 请求格式转化
        /// </summary>
        /// <param name="request"></param>
        public static void TransfeRequestForamt(Request request)
        {
            //request.Content.Content=TransfeRequestForRest.Transfe(request.Content.Content);
        }

        /// <summary>
        /// 压缩请求
        /// </summary>
        /// <param name="request"></param>
        public static void ReduceRequest(Request request)
        {
            //ReduceRequestBody.Reduce(request);
        }

    }
}