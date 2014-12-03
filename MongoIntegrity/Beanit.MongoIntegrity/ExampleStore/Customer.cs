using MongoDB.Bson;

namespace Beanit.MongoIntegrity.ExampleStore
{
    public class Customer : IDocument<ObjectId>
    {
        public ObjectId Id { get; set; }
    }
}
