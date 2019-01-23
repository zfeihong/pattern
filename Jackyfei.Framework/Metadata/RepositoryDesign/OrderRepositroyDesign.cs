using System.Collections.Generic;
using Jackyfei.Framework.Metadata.Memory;

namespace Jackyfei.Framework.Metadata.RepositoryDesign
{
    public partial class OrderRepositroyDesign :RepositoryDesignBase
    {

        protected override void AddItem(MemoryMetadataPool pool)
        {
            var orderTable = new MemoryTableMetadata(){TableName = "Table_Order"};
            orderTable.Columns = new List<MemoryColumnMetadata>();
            orderTable.Columns.Add(new MemoryColumnMetadata(){ColumnName = "OrderId"});
            orderTable.Columns.Add(new MemoryColumnMetadata(){ColumnName = "CustomerId"});
            orderTable.Columns.Add(new MemoryColumnMetadata(){ColumnName = "Address"});
             
            pool.AddPoolItem(new MemoryPoolItem()
            {
                Item = orderTable,
                Key = typeof(Order).ToString()
            });

        }
    }
}