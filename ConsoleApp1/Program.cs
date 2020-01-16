using ExtensionHeper;
using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
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
