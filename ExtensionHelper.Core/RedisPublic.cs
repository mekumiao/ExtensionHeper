using CSRedis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionHeper
{
    public class RedisPublic
    {
        public static RedisClient CreateDefaultClient()
        {
            return new RedisClient("127.0.0.1", 6379);
        }

        public static RedisClient CreateClient(string connstring)
        {
            var ls = connstring.Split(':');
            if (ls == null || ls.Length != 2) throw new Exception("Redis连接字符串错误");
            var host = ls[0];
            var port = Convert.ToInt32(ls[1]);
            return new RedisClient(host, port);
        }

    }
}
