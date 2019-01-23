using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jackyfei.Framework.Passivation.Entity
{
    public class Order
    {
        public string OrderId{ get; set; }

        public CustomerInfo Customer{ get; set; }

        public List<OrderItem> Items { get; set; }
    }
}
