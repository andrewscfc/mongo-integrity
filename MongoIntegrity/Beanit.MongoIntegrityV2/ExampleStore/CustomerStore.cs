using Beanit.MongoIntegrityV2.CollectionStore.ObjectId;
using MongoDB.Driver;

namespace Beanit.MongoIntegrityV2.ExampleStore
{
    public class CustomerStore : CollectionStoreObjectId<Customer>
    {
        public CustomerStore(MongoDatabase mongoDatabase) : base(mongoDatabase)
        {
        }

        public override string CollectionName
        {
            get { return "Customer"; }
        }
    }
}
