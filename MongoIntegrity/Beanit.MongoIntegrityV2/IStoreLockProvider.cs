using Beanit.MongoIntegrityV2.CollectionStore;

namespace Beanit.MongoIntegrityV2
{
    public interface IStoreLockProvider
    {
        object GetLock<TCollectionStore>() where TCollectionStore : ICollectionStore;
    }
}