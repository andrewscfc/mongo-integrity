using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Beanit.MongoIntegrity.CollectionStore;

namespace Beanit.MongoIntegrity
{
    public interface ITransactionRunner<TIdentifier, TDocument, TCollectionStore> 
        where TDocument : ITypedDocument<TIdentifier>
        where TCollectionStore : ITypedCollectionStore<TIdentifier, TDocument>
    {
        void ExecuteTransaction(TDocument document, TransactionOperation operation);
    }
}
