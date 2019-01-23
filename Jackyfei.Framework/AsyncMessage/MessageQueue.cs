using Jackyfei.Framework.AsyncMessage.Entity;
using System.Collections.Generic;
using System.Timers;

namespace Jackyfei.Framework.AsyncMessage
{

    public delegate void MessageQueueEventNotifyHandler(Message message);
    /// <summary>
    /// 异步消息队列
    /// </summary>
    public class MessageQueue:Queue<Message>
    {
        public static MessageQueue GlobalQueue = new MessageQueue();

        private readonly Timer _timer=new Timer();

        /// <summary>
        /// 构造一个新的消息队列
        /// </summary>
        public MessageQueue()
        {
            this._timer.Interval = 500;
            this._timer.Elapsed += Notify;
            this._timer.Enabled = true;
        }

        void Notify(object sender, ElapsedEventArgs e)
        {
            lock (this)
            {
                if (this.Count>0)
                {
                    this.messageNotifyEvent.GetInvocationList()[0].DynamicInvoke(this.Dequeue());
                }
            }
        }

        /// <summary>
        /// 队列通知索引器
        /// </summary>
        public MessageQueueEventNotifyHandler messageNotifyEvent;

        /// <summary>
        /// 队列通知事件
        /// </summary>
        public event MessageQueueEventNotifyHandler MessageNotifyEvent
        {
            add { this.messageNotifyEvent += value; }
            remove {
                if (messageNotifyEvent != null)
                {
                    this.messageNotifyEvent -= value;
                }
            }
        }


    }
}
