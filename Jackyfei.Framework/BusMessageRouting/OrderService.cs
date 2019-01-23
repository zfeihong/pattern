using System;
using Jackyfei.Framework.BusMessageRouting.Entity;

namespace Jackyfei.Framework.BusMessageRouting
{
    public class OrderService:ServiceBase
    {
        /// <summary>
        /// 注册OrderService服务中的所有服务与请求对应项
        /// </summary>
        /// <param name="register"></param>
        protected override void RegisterServiceRequest(ServiceRegister register)
        {
            //此字符串可以考虑放在配置中
            register.Register("OrderService.SubmitOrder", (object parameter, ref object result) =>
            {
                result = this.SubmitOrder(parameter as Order);
            });
            //此字符串可以考虑放在配置中
            register.Register("OrderService.DeleteOrder", (object parameter, ref object result) =>
            {
                result = this.DeleteOrder(parameter as Order);
            });
        }

        public bool SubmitOrder(Order order)
        {
            Console.WriteLine("提交订单{0}",order.OrderId);
            return true;
        }
        public bool DeleteOrder(Order order)
        {
            Console.WriteLine("删除订单{0}", order.OrderId);
            return true;
        }
    }
}