﻿using MongoDB.Driver;

namespace Beanit.MongoIntegrity.CollectionStore.ObjectId
{
    public abstract class CollectionStoreObjectId<TDocument> : CustomIdentifierCollectionStore<MongoDB.Bson.ObjectId, TDocument> where TDocument : IDocumentObjectId
    {
        protected CollectionStoreObjectId(MongoDatabase mongoDatabase) : base(mongoDatabase)
        {
        }
    }
}
