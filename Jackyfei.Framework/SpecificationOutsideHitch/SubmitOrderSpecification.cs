using System;
using Jackyfei.Framework.SpecificationOutsideHitch.Entity;

namespace Jackyfei.Framework.SpecificationOutsideHitch
{
    /// <summary>
    /// 提交订单规则
    /// </summary>
    [Serializable]
    public class SubmitOrderSpecification
    {
        public bool CheckSubmitVipOrder(Order order)
        {
            if (order.Customer.CustomerType==CustomerType.Vip)
            {
                return true;
            }
            return false;
        }

        public bool CheckSubmitNormalOrder(Order order)
        {
            if (order.Customer.CustomerType == CustomerType.Normal)
            {
                return true;
            }
            return false;
        }
    }
}