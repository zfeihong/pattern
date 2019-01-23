using System;

namespace Jackyfei.Framework.AsyncMessage.Entity
{
    /// <summary>
    /// 消息对象
    /// </summary>
    [Serializable]
    public class Message
    {
        public string MessageKey{ get;private set; }

        public Message()
        {
            this.MessageKey = Guid.NewGuid().ToString();
        }
         
        public object Body { get; set; }

    }
}