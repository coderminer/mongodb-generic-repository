﻿using MongoDbGenericRepository;

namespace IntegrationTests.Infrastructure
{
    public class TestRepository : BaseMongoRepository, ITestRepository
    {
        /// <inheritdoc />
        public TestRepository(string connectionString, string databaseName) : base(connectionString, databaseName)
        {
        }

        public void DropTestCollection<TDocument>()
        {
            MongoDbContext.DropCollection<TDocument>();
        }

        public void DropTestCollection<TDocument>(string partitionKey)
        {
            MongoDbContext.DropCollection<TDocument>(partitionKey);
        }
    }
}
