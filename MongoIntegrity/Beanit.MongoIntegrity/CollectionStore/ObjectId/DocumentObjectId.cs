namespace Beanit.MongoIntegrity.CollectionStore.ObjectId
{
    public class DocumentObjectId : IDocumentObjectId
    {
        object IDocument.Id
        {
            get { return Id; }
            set { Id = (MongoDB.Bson.ObjectId) value; }
        }

        public MongoDB.Bson.ObjectId Id { get; set; }
    }
}