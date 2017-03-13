using System.Threading.Tasks;
using StackExchange.Redis;

namespace Redis.WebJobs.Extensions
{
    internal static class RedisClient
    {
        public static IDatabase CreateDbFromConnectionString(string connectionString)
        {
            ConnectionMultiplexer redisConnection = ConnectionMultiplexer.Connect(connectionString);
            return redisConnection.GetDatabase();
        }

        public static async Task<IDatabase> CreateDbFromConnectionStringAsync(string connectionString)
        {
            ConnectionMultiplexer redisConnection = await ConnectionMultiplexer.ConnectAsync(connectionString);
            return redisConnection.GetDatabase();
        }

        public static ConnectionMultiplexer CreateConnectionFromConnectionString(string connectionString)
        {
            return ConnectionMultiplexer.Connect(connectionString);
        }

        public static async Task<ConnectionMultiplexer> CreateConnectionFromConnectionStringAsync(string connectionString)
        {
            return await ConnectionMultiplexer.ConnectAsync(connectionString);
        }
    }
}
