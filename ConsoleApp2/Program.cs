using CSRedis;
using ExtensionHeper;
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var redis = new RedisClient("127.0.0.1", 6379);
            using (var uuid = new RedisUUID(redis, "wyl", 0))
            {
                var array = uuid.GetUUID(1000);
                var obj = new { array };
                Console.WriteLine(obj.ToJson());
            }
        }
    }
}
