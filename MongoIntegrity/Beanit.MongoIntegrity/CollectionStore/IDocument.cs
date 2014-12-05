namespace Beanit.MongoIntegrity.CollectionStore
{
    public interface IDocument<TIdentifer>
    {
        TIdentifer Id { get; set; }
    }
}
