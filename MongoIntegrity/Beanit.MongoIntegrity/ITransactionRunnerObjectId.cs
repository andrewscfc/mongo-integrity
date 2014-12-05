using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Beanit.MongoIntegrity.CollectionStore;
using Beanit.MongoIntegrity.CollectionStore.ObjectId;
using MongoDB.Bson;

namespace Beanit.MongoIntegrity
{
    public interface ITransactionRunnerObjectId : ITransactionRunner<IDocumentObjectId, ObjectId>
    {
    }
}
