namespace Jackyfei.Framework.Context
{
    public class ServiceProxyRequest:Request
    {
        /// <summary>
        /// 门票ID
        /// </summary>
        public string TicketId{ get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public int Price{ get; set; }
    }
}