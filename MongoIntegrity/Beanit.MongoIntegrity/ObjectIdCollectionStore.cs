using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Beanit.MongoIntegrity
{
    public abstract class ObjectIdCollectionStore<TDocument> : CustomIdentifierCollectionStore<ObjectId, TDocument> where TDocument : IDocument<ObjectId>
    {
        protected ObjectIdCollectionStore(MongoDatabase mongoDatabase) : base(mongoDatabase)
        {
        }
    }
}
