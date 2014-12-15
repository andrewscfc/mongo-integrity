using Beanit.MongoIntegrity.CollectionStore;

namespace Beanit.MongoIntegrity
{
    public interface IStoreLockProvider
    {
        object GetLock<TCollectionStore>() where TCollectionStore : ICollectionStore;
    }
}