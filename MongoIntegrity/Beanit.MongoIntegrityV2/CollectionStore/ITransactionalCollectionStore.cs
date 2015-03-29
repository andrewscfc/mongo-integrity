using System.Collections.Generic;

namespace Beanit.MongoIntegrityV2.CollectionStore
{
    public interface ITransactionalCollectionStore<TIdentifier, TDocument> where TDocument : ITypedDocument<TIdentifier>
    {
        IEnumerable<TDocument> Get();
        TDocument Get(TIdentifier id);
        IEnumerable<TransactionFailure> Update(TDocument document);
        IEnumerable<TransactionFailure> Add(TDocument document);
        IEnumerable<TransactionFailure> Delete(TIdentifier id);
    }
}