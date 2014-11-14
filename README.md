#mongo-integrity#
##What is it?##
A data integrity layer targeted for the Mongo DB Database.
- Checks documents pass rules before a database commit and rollback if not
- Update documents in the database based on the addition/modification/deletion of others

##Why?##
Mongo isn't a relational database; it has no system of constraints to maintain the integrity of data. 

This is a consequence of its principal requirment to automatically scale over shards. Distributed data integrity would fundamentally undermine the automatic scalability of Mongo with integrity having to be checked across all shards, causing very slow insert/update responses. 

This project aims to provide an abstracted, reliable way of maintaining data integrity in a single shard implementation of Mongo. 

Not every project needs to scale across shards, but many projects would benefit from reliable way of ensuring data stays correct and up-to-date across documents and collections.
