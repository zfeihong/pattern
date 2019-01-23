namespace Jackyfei.Framework.Metadata.Memory
{
    /// <summary>
    /// 元数据缓存池项用来对存储在缓存池中的对象进行包装，方便管理
    /// </summary>
    public class MemoryPoolItem
    {
        public string Key{ get; set; }
        public object Item{ get; set; }
    }
}