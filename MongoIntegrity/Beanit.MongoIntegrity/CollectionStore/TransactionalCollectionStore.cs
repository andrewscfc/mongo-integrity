using System.Collections.Generic;

namespace Beanit.MongoIntegrity.CollectionStore
{
    public class TransactionalCollectionStore<TIdentifier, TDocument> : ITransactionalCollectionStore<TIdentifier, TDocument> where TDocument : IDocument<TIdentifier>
    {
        private readonly ITransactionRunner<TIdentifier, TDocument, ICollectionStore<TIdentifier, TDocument>> _transactionRunner;
        private readonly ICollectionStore<TIdentifier, TDocument> _rawCollectionStore;

        public TransactionalCollectionStore(
            ITransactionRunner<TIdentifier, TDocument, ICollectionStore<TIdentifier, TDocument>> transactionRunner,
            ICollectionStore<TIdentifier,TDocument> rawCollectionStore)
        {
            _transactionRunner = transactionRunner;
            _rawCollectionStore = rawCollectionStore;
        }

        public IEnumerable<TDocument> Get()
        {
            return _rawCollectionStore.Get();
        }

        public TDocument Get(TIdentifier id)
        {
            return _rawCollectionStore.Get(id);
        }

        public void Update(TDocument document)
        {
            _transactionRunner.ExecuteTransaction(document, TransactionOperation.Update);
        }

        public void Add(TDocument document)
        {
            _transactionRunner.ExecuteTransaction(document, TransactionOperation.Add);
        }

        public void Delete(TIdentifier id)
        {
            var document = _rawCollectionStore.Get(id);
            _transactionRunner.ExecuteTransaction(document, TransactionOperation.Delete);
        }
    }
}