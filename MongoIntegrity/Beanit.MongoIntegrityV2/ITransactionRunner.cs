using System.Collections.Generic;
using Beanit.MongoIntegrityV2.CollectionStore;

namespace Beanit.MongoIntegrityV2
{
    public interface ITransactionRunner<TIdentifier, TDocument, TCollectionStore> 
        where TDocument : ITypedDocument<TIdentifier>
        where TCollectionStore : ITypedCollectionStore<TIdentifier, TDocument>
    {
        IEnumerable<TransactionFailure> ExecuteTransaction(TDocument document, TransactionOperation operation);
    }
}
