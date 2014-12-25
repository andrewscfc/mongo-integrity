using System.Collections.Generic;
using MongoDB.Driver;

namespace Beanit.MongoIntegrity.CollectionStore
{
    public abstract class TransactionalCollectionStore<TIdentifier, TDocument> : 
        CollectionStoreRaw<TIdentifier, TDocument>,
        ITransactionalCollectionStore<TIdentifier, TDocument> where TDocument : ITypedDocument<TIdentifier>
    {
        private readonly ITransactionRunner<TIdentifier, TDocument, ITypedCollectionStore<TIdentifier, TDocument>> _transactionRunner;
        private readonly ITypedCollectionStore<TIdentifier, TDocument> _rawCollectionStore;

        public TransactionalCollectionStore(
            MongoDatabase mongoDatabase,
            ITransactionRunner<TIdentifier, TDocument, ITypedCollectionStore<TIdentifier, TDocument>> transactionRunner
            ) : 
            base(mongoDatabase)
        {
            _transactionRunner = transactionRunner;
        }

        public IEnumerable<TransactionFailure> Update(TDocument document)
        {
            return _transactionRunner.ExecuteTransaction(document, TransactionOperation.Update);
        }

        public IEnumerable<TransactionFailure> Add(TDocument document)
        {
            return _transactionRunner.ExecuteTransaction(document, TransactionOperation.Add);
        }

        public IEnumerable<TransactionFailure> Delete(TIdentifier id)
        {
            var document = _rawCollectionStore.Get(id);
            return _transactionRunner.ExecuteTransaction(document, TransactionOperation.Delete);
        }
    }
}