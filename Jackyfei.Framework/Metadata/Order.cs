using System.Collections.Generic;
using Jackyfei.Framework.Metadata.Entity;

namespace Jackyfei.Framework.Metadata
{
    /// <summary>
    /// Order是一个领域对象，有自己的行为，属性，字段，
    /// 不适合做存储使用
    /// </summary>
    public class Order
    {
        public string OrderId{ get; set; }
        public string CustomerId { get; set; }
        public string Address{ get; set; }

        private readonly Dictionary<string,Item> _items=new Dictionary<string, Item>();

        public void AddItem(Item item)
        {
            if (item!=null&&item.ProductId.StartsWith("P")&&item.Number>0)
            {
                this._items.Add(item.ItemId, item);
            }
        }

        public void DeleteItem(string itemId)
        {
            if (this._items.ContainsKey(itemId))
            {
                this._items.Remove(itemId);
            }
        }
    }
}