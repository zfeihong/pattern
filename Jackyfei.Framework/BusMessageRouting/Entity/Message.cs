namespace Jackyfei.Framework.BusMessageRouting.Entity
{
    /// <summary>
    /// 消息对象：用于客户端发起请求的包装
    /// 包括头和正文，正文跟业务相关的对象实体
    /// </summary>
    public class Message
    {
        public MessageHeader Header{ get; set; }

        public object Body{ get; set; }
    }
}