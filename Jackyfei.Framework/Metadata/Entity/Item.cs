using System;

namespace Jackyfei.Framework.Metadata.Entity
{
    public class Item
    {
        public Item()
        {
            this.ItemId = Guid.NewGuid().ToString();
        }

        public string ItemId{ get; set; }
        public string ProductId{ get; set; }
        public int Number{ get; set; }

    }
}