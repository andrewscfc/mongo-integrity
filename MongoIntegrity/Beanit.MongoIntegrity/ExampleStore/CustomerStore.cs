using Beanit.MongoIntegrity.CollectionStore.ObjectId;
using MongoDB.Driver;

namespace Beanit.MongoIntegrity.ExampleStore
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
