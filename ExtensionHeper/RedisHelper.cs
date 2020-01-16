using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionHeper
{
    public class RedisHelper
    {
        public static RedisClient CreateDefaultClient()
        {
            return new RedisClient("127.0.0.1", 6379);
        }

    }
}
