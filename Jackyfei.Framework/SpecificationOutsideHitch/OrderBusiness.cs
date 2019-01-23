using Jackyfei.Framework.SpecificationOutsideHitch.Entity;

namespace Jackyfei.Framework.SpecificationOutsideHitch
{
    public class OrderBusiness
    {
        private readonly OrderSpecificationManager _orderSpecManager;
        public OrderBusiness(OrderSpecificationManager orderSpecManager)
        {
            this._orderSpecManager = orderSpecManager;
        }

        public void SubmitOrder(Order order)
        {
            //该处可以做成可以配置，根据配置来选择业务规则
            var spec = _orderSpecManager.GetSpecification(CustomerType.Vip);

            if (order.Customer.CustomerType == CustomerType.Vip && spec(order))
            {
                //处理VIP订单逻辑
            }
            else if (order.Customer.CustomerType ==CustomerType.Normal && spec(order))
            {
                //处理普通订单逻辑
            }
        } 
    }
}