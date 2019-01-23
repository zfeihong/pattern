namespace Jackyfei.Framework.BusMessageRouting.Entity
{
    public class MessageHeader
    {
        /// <summary>
        /// 是消息在全局下的唯一标识
        /// 为了在全局下进行跟踪和定位用的
        /// </summary>
        public string MessageKey{ get; set; }
        /// <summary>
        /// 请求KEY，也可以称为请求服务的方法名
        /// 用在消息总线中，辅助路由，找到对应的服务用的  
        /// </summary>
        public string RequestKey{ get; set; }
    }
}