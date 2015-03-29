using System.Collections.Generic;
using Beanit.MongoIntegrityV2.CollectionStore;

namespace Beanit.MongoIntegrityV2
{
    public class TransactionRunner<TDocument, TIdentifier, TCollectionStore> : ITransactionRunner<TIdentifier, TDocument, TCollectionStore> 
        where TDocument : ITypedDocument<TIdentifier> 
        where TCollectionStore : ITypedCollectionStore<TIdentifier, TDocument>
    {
        private readonly IStoreLockProvider _storeLockProvider;

        public TransactionRunner(IStoreLockProvider storeLockProvider)
        {
            _storeLockProvider = storeLockProvider;
        }

        public IEnumerable<TransactionFailure> ExecuteTransaction(TDocument document, TransactionOperation operation)
        {
            object storeLock = _storeLockProvider.GetLock<TCollectionStore>();

            lock (storeLock)
            {
                return new TransactionFailure[]{};
            }
        }
    }
}