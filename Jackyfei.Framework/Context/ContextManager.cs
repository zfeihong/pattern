using System;
using Jackyfei.Framework.Context;

namespace Jackyfei.Framework
{
    /// <summary>
    /// SOA上下文管理对象，负责所有代理的感知
    /// 将感知上下文[SOAServiceCallContext]插入到一个高层类[ContextManager]，让后继的实现者都具有上下文协调能力
    /// </summary>
    public class ContextManager
    {
        /// <summary>
        /// 当前上下文属性
        /// </summary>
        public SOAServiceCallContext CurrentContext
        {
            get { return SOAServiceCallContext.context;}
        }
         

        /// <summary>
        /// 感知服务调用上下文
        /// </summary>
        /// <param name="request"></param>
        protected void ApperceiveContext(Request request)
        {
            if (SOAServiceCallContext.context!=null)
            {
                //感知日志跟踪
                request.LogTrackId = CurrentContext.LogTrack ? Guid.NewGuid() : new Guid();
                //感知事务处理
                request.TransactionId = CurrentContext.Transaction ? Guid.NewGuid() : new Guid();

            }
        }
    }
}