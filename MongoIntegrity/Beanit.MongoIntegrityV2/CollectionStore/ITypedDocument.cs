namespace Beanit.MongoIntegrityV2.CollectionStore
{
    public interface ITypedDocument<TIdentifer> : IDocument
    {
        TIdentifer Id { get; set; }
    }
}
