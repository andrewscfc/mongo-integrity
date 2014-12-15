namespace Beanit.MongoIntegrity.CollectionStore
{
    public interface ITypedDocument<TIdentifer> : IDocument
    {
        TIdentifer Id { get; set; }
    }
}
