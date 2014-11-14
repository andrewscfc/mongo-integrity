using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beanit.MongoIntegrity
{
    public interface ICollectionStore<in TIdentifier, TDocument> where TDocument : IDocument<TIdentifier>
    {
        IEnumerable<TDocument> Get();

        TDocument Get(TIdentifier id);

        void Update(TDocument document);

        void Add(TDocument document);

        void Delete(TIdentifier id);

    }
}
