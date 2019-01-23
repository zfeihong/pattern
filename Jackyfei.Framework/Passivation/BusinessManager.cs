using System;
using System.Linq;
using Jackyfei.Framework.Passivation.Entity;

namespace Jackyfei.Framework.Passivation
{
    [Serializable]
    public class BusinessManager
    {
        public bool CheckPhoneConfirm(Order order,ref OrderExamineManagerHandler manager)
        {
            if (OrderExamineHelper.CallPhoneConfirm(order.Customer.Phone))
            {
                manager -= this.CheckPhoneConfirm;
                return true;
            }
            return false;
        }

        public bool SendEmailNotice(Order order, ref OrderExamineManagerHandler manager)
        {
            if (OrderExamineHelper.SendEmail(order.Customer.Email))
            {
                manager -= this.SendEmailNotice;
                return true;
            }
            return false;
        }
    }
}