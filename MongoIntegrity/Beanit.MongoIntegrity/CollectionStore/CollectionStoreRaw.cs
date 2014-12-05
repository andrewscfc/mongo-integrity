using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;

namespace Beanit.MongoIntegrity.CollectionStore
{
    public abstract class CollectionStoreRaw<TIdentifier, TDocument> : ICollectionStore<TIdentifier, TDocument> where TDocument : IDocument<TIdentifier>
    {
        private readonly MongoDatabase _mongoDatabase;
        private MongoCollection<TDocument> _collection;
        public abstract string CollectionName { get; }

        protected MongoCollection<TDocument> Collection
        {
            get
            {
                if (_collection == null)
                {
                    _collection = _mongoDatabase.GetCollection<TDocument>(CollectionName);
                }

                return _collection;
            }
        }


        public CustomIdentifierCollectionStore(MongoDatabase mongoDatabase)
        {
            _mongoDatabase = mongoDatabase;
            
        }

        public IEnumerable<TDocument> Get()
        {
            return Collection.FindAllAs<TDocument>();
        }

        public TDocument Get(TIdentifier id)
        {
            return Collection.AsQueryable().Single(x => x.Id.Equals(id));
        }

        public void Update(TDocument document)
        {
            Collection.Update(
                Query.EQ("_id", BsonValue.Create(document.Id)),
                MongoDB.Driver.Builders.Update.Replace(document));
        }

        public void Add(TDocument document)
        {
            Collection.Insert(document);
        }

        public void Delete(TIdentifier id)
        {
            Collection.Remove(Query.EQ("_id", BsonValue.Create(id)));
        }
    }
}