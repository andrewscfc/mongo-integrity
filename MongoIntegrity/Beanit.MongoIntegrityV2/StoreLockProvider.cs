using System;
using System.Collections.Generic;
using Beanit.MongoIntegrityV2.CollectionStore;

namespace Beanit.MongoIntegrityV2
{
    public class StoreLockProvider : IStoreLockProvider
    {
        private IDictionary<Type, object> _locks;

        public StoreLockProvider()
        {
            _locks = new Dictionary<Type, object>();
        }

        public object GetLock<TCollectionStore>() where TCollectionStore : ICollectionStore
        {
            var storeType = typeof (TCollectionStore);

            lock (_locks)
            {
                if (!_locks.ContainsKey(storeType))
                {
                    _locks[storeType] = new object();
                }

                return _locks[storeType];
            }
        } 
    }
}
