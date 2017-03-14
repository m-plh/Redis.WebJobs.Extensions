﻿using StackExchange.Redis;

namespace Redis.WebJobs.Extensions
{
    internal static class RedisClient
    {
        public static IDatabase CreateDbFromConnectionString(string connectionString)
        {
            ConnectionMultiplexer redisConnection = ConnectionMultiplexer.Connect(connectionString);
            return redisConnection.GetDatabase();
        }

        public static ConnectionMultiplexer CreateConnectionFromConnectionString(string connectionString)
        {
            return ConnectionMultiplexer.Connect(connectionString);
        }
    }
}
