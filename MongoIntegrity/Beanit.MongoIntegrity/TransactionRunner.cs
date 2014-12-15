﻿using System;
using System.Collections.Generic;
using Beanit.MongoIntegrity.CollectionStore;

namespace Beanit.MongoIntegrity
{
    public class TransactionRunner<TDocument, TIdentifier, TCollectionStore> : ITransactionRunner<TIdentifier, TDocument, TCollectionStore> 
        where TDocument : ITypedDocument<TIdentifier>
        where TCollectionStore : ITypedCollectionStore<TIdentifier, TDocument>
    {
        private readonly IStoreLockProvider _storeLockProvider;

        public TransactionRunner(IStoreLockProvider storeLockProvider)
        {
            _storeLockProvider = storeLockProvider;
        }

        public void ExecuteTransaction(TDocument document, TransactionOperation operation)
        {
            object storeLock = _storeLockProvider.GetLock<TCollectionStore>();

            lock (storeLock)
            {
                
            }
        }
    }
}