using System.Collections.Generic;
using Jackyfei.Framework.Metadata.Entity;
using Jackyfei.Framework.Metadata.Memory;

namespace Jackyfei.Framework.Metadata.RepositoryDesign
{
    public partial class ItemRepositroyDesign : RepositoryDesignBase
    {

        protected override void AddItem(MemoryMetadataPool pool)
        {
            var orderTable = new MemoryTableMetadata(){TableName = "Table_OrderItem"};
            orderTable.Columns = new List<MemoryColumnMetadata>();
            orderTable.Columns.Add(new MemoryColumnMetadata() { ColumnName = "ItemId" });
            orderTable.Columns.Add(new MemoryColumnMetadata() { ColumnName = "ProductId" });
            orderTable.Columns.Add(new MemoryColumnMetadata() { ColumnName = "Number" });
             
            pool.AddPoolItem(new MemoryPoolItem()
            {
                Item = orderTable,
                Key = typeof(Item).ToString()
            });

        }
    }
}