using System;
using System.Collections.Generic;
using Beanit.MongoIntegrity.CollectionStore;

namespace Beanit.MongoIntegrity
{
    public class TransactionRunner<TDocument, TIdentifier, TCollectionStore> : ITransactionRunner<TIdentifier, TDocument, TCollectionStore> 
        where TDocument : IDocument<TIdentifier>
        where TCollectionStore : ICollectionStore<TIdentifier, TDocument>
    {
        private IDictionary<Type, object> _locks;

        public TransactionRunner()
        {
            _locks =new Dictionary<Type, object>();
        }

        public void ExecuteTransaction(TDocument document, TransactionOperation operation)
        {
            object storeLock;

            lock (_locks)
            {
                var storeType = typeof (TCollectionStore);
                if (!_locks.ContainsKey(storeType))
                {
                    _locks.Add(storeType, new object());
                }

                storeLock = _locks[storeType];
            }

            lock (storeLock)
            {
                
            }
        }
    }
}