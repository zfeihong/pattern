using System;
using System.Collections.Generic;
using Jackyfei.Framework.SpecificationOutsideHitch.Entity;

namespace Jackyfei.Framework.SpecificationOutsideHitch
{

    public delegate bool OrderSpecifcationIndex(Order order);

    /// <summary>
    /// 订单规则管理器
    /// </summary>
    [Serializable]
    public class OrderSpecificationManager:IDisposable
    {
        public Dictionary<CustomerType, OrderSpecifcationIndex> Specifcation { get; set; }

        public OrderSpecifcationIndex GetSpecification(CustomerType type)
        {
            if (this.Specifcation.ContainsKey(type))
            {
                return this.Specifcation[type];
            }
            return null;
        }

        public void Dispose()
        {
            OrderSpecificationManagerFactory.FreezeOrderSpecificationManager(this);
        }
    }
}