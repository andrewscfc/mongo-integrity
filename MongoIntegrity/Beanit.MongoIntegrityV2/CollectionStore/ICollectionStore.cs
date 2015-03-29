using System.Collections;

namespace Beanit.MongoIntegrityV2.CollectionStore
{
    public interface ICollectionStore
    {
        IEnumerable Get();

        IDocument Get(object id);

        void Update(IDocument document);

        void Add(IDocument document);

        void Delete(object id);
    }
}
