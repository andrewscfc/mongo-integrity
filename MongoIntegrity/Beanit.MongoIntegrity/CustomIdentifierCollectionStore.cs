using System;
using System.Collections.Generic;

namespace Beanit.MongoIntegrity
{
    public abstract class CustomIdentifierCollectionStore<TIdentifier, TDocument> : ICollectionStore<TIdentifier, TDocument> where TDocument : IDocument<TIdentifier>
    {
        public abstract string CollectionName { get; }

        public IEnumerable<TDocument> Get()
        {
            throw new NotImplementedException();
        }

        public TDocument Get(TIdentifier id)
        {
            throw new NotImplementedException();
        }

        public void Update(TDocument document)
        {
            throw new NotImplementedException();
        }

        public void Add(TDocument document)
        {
            throw new NotImplementedException();
        }

        public void Delete(TIdentifier id)
        {
            throw new NotImplementedException();
        }
    }
}