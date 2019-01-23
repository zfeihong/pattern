using System.Collections.Generic;

namespace Jackyfei.Framework.Metadata.Memory
{
    /// <summary>
    /// 领域实体持久化表元数据
    /// </summary>
    public class MemoryTableMetadata
    {
        public string TableName{ get; set; }
        public List<MemoryColumnMetadata> Columns{ get; set; }
    }
}