using System.Collections.Generic;

namespace Beanit.MongoIntegrity.CollectionStore
{
    public interface ITypedCollectionStore<in TIdentifier, TDocument> : ICollectionStore
        where TDocument : ITypedDocument<TIdentifier>
    {
        IEnumerable<TDocument> Get();

        TDocument Get(TIdentifier id);

        void Update(TDocument document);

        void Add(TDocument document);

        void Delete(TIdentifier id);

    }
}
