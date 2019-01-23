namespace Jackyfei.Framework.Context
{
    /// <summary>
    /// 远程服务代理类
    /// 与上下文相关的抽象被放到ContextManager当中，所有客户端只要继承了该高层类，就会自动被纳入服务上下文中
    /// 同时获得了上下文[SOAServiceCallContext]的感知能力
    /// </summary>
    public class ServiceProxy : ContextManager
    {
        public void SetTicketPrice(string ticketId,int price)
        {
            base.ApperceiveContext(new ServiceProxyRequest() { TicketId = ticketId, Price = price });
        }

        public void UpdateTicketCache(string ticketId, int price)
        {
            base.ApperceiveContext(new ServiceProxyRequest() { TicketId = ticketId, Price = price });
        }


    }
}