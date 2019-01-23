using System;
using System.Linq;
using Jackyfei.Framework.Passivation.Entity;

namespace Jackyfei.Framework.Passivation
{
    [Serializable]
    public class GeneralManager
    {
        public bool FinalConfirm(Order order,ref OrderExamineManagerHandler manager)
        {
            if (OrderExamineHelper.CallPhoneConfirm(order.Customer.Phone))
            {
                manager -= this.FinalConfirm;
                return true;
            }
            return false;
        }

        public bool SignAndRecord(Order order, ref OrderExamineManagerHandler manager)
        {
            //签字，备案记录
            if (OrderExamineHelper.SignAndRecord(order.OrderId))
            {
                manager -= this.SignAndRecord;
                return true;
            }
            return false;
        }
    }
}