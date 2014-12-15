using System.Collections;
using System.Collections.Generic;

namespace Beanit.MongoIntegrity.CollectionStore
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
