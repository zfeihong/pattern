using Jackyfei.Framework.Metadata.Memory;

namespace Jackyfei.Framework.Metadata.RepositoryDesign
{
    public abstract class RepositoryDesignBase
    {
        public void BeginAddItem()
        {
            this.AddItem(MemoryMetadataPool.GlobalPool);
        }

        protected abstract void AddItem(MemoryMetadataPool pool);


    }
}