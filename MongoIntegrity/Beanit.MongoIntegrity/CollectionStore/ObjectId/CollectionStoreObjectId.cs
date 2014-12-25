using MongoDB.Driver;

namespace Beanit.MongoIntegrity.CollectionStore.ObjectId
{
    public abstract class CollectionStoreObjectId<TDocument> : TransactionalCollectionStore<MongoDB.Bson.ObjectId, TDocument> where TDocument : IDocumentObjectId
    {
        protected CollectionStoreObjectId(MongoDatabase mongoDatabase) : base(
            mongoDatabase,
            new TransactionRunner<TDocument, MongoDB.Bson.ObjectId, ITypedCollectionStore<MongoDB.Bson.ObjectId, TDocument>>(new StoreLockProvider()))
        {
        }

        protected CollectionStoreObjectId(MongoDatabase mongoDatabase,
            TransactionRunner<TDocument, MongoDB.Bson.ObjectId, ITypedCollectionStore<MongoDB.Bson.ObjectId, TDocument>> transactionRunner) : 
            base(mongoDatabase, transactionRunner)
        {
        
        } 
    }
}
