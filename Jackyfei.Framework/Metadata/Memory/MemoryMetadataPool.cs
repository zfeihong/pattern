using System.Collections.Generic;

namespace Jackyfei.Framework.Metadata.Memory
{
    public class MemoryMetadataPool : Dictionary<string, MemoryPoolItem>
    {
        public static  MemoryMetadataPool GlobalPool=new MemoryMetadataPool();

        public void AddPoolItem(MemoryPoolItem poolItem)
        {
            this.Add(poolItem.Key,poolItem);
        }
    }
}