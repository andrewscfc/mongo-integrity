using System.Collections.Generic;

namespace Beanit.MongoIntegrity.CollectionStore
{
    public interface ICollectionStore<in TIdentifier, TDocument> where TDocument : IDocument<TIdentifier>
    {
        IEnumerable<TDocument> Get();

        TDocument Get(TIdentifier id);

        void Update(TDocument document);

        void Add(TDocument document);

        void Delete(TIdentifier id);

    }
}
