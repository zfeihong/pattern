using System;

namespace Jackyfei.Framework
{
    /// <summary>
    /// 上下文的事件委托
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="arg"></param>
    public delegate void SOAServiceCallContextHandler<T>(T arg) where T : class;

    /// <summary>
    /// SOA服务调用上下文
    /// 需要有生命周期特性；同时需要有生命周期事件，让使用者能跟踪到上下文目前的处理状态，毕竟外部是不知道上下文都包含了哪些过程，所以必须使用事件通知来告知使用者
    /// </summary>
    public class SOAServiceCallContext:IDisposable
    {
        internal static SOAServiceCallContext context;
        /// <summary>
        /// 是否开启服务调用事务
        /// </summary>
        public bool Transaction{ get; private set; }
        /// <summary>
        /// 是否开启日志跟踪
        /// </summary>
        public bool LogTrack{ get; set; }

        public SOAServiceCallContext(bool transaction,bool logTrack)
        {
            this.Transaction = transaction;
            this.LogTrack = logTrack;

            //设置一个服务调用上下文的访问点，便于被感知
            SOAServiceCallContext.context = this;
        }

        private SOAServiceCallContextHandler<LogTracklocation> beginRecordLogTrackHandler;

        /// <summary>
        /// SOA服务调用上下文已经开始记录跟踪日志
        /// </summary>
        public event SOAServiceCallContextHandler<LogTracklocation> BeginRecordLogTrackEvent
        {
            add { this.beginRecordLogTrackHandler += value; }
            remove
            {
                if (this.beginRecordLogTrackHandler != null)
                {
                    this.beginRecordLogTrackHandler -= value;
                }
            }
        }

        private SOAServiceCallContextHandler<TransactionActionInfo> transactionEndHandler;

        /// <summary>
        /// 事务执行结束后的动作信息
        /// </summary>
        public event SOAServiceCallContextHandler<TransactionActionInfo> TransactionEndEvent
        {
            add { this.transactionEndHandler += value; }
            remove
            {
                if (this.transactionEndHandler != null)
                {
                    this.transactionEndHandler -= value;
                }
            }
        }


        public void Dispose()
        {
            this.transactionEndHandler = null;
            this.beginRecordLogTrackHandler = null;
        }
    }


     

    public class LogTracklocation  
    {

    }

    public class TransactionActionInfo 
    {

    }
}