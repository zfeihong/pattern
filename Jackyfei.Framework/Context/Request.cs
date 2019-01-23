using System;

namespace Jackyfei.Framework.Context
{
    /// <summary>
    /// SOA服务请求
    /// </summary>
    public class Request
    {
        /// <summary>
        /// 分布式事务ID
        /// </summary>
        public Guid TransactionId { get; set; }
        /// <summary>
        /// 全局跟踪LogId
        /// </summary>
        public Guid LogTrackId{ get; set; }

    }
}