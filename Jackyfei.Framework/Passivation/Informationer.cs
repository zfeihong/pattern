using System;
using System.Linq;
using Jackyfei.Framework.Passivation.Entity;

namespace Jackyfei.Framework.Passivation
{
    [Serializable]
    public class Informationer
    {
        public bool CheckPrice(Order order,ref OrderExamineManagerHandler manager)
        {
            if (order.Items.Any(item=>item.Product.Price<0))
            {
                manager -= this.CheckPrice;
                return true;
            }
            return false;
        }

        public bool CheckNumber(Order order, ref OrderExamineManagerHandler manager)
        {
            if (order.Items.Any(item=>item.Number>10))
            {
                manager -= this.CheckNumber;
                return true;
            }
            return false;
        }
    }
}