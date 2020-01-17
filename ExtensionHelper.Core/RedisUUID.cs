using CSRedis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionHeper
{
    public class RedisUUID : IRedisUUID, IDisposable
    {
        private RedisClient Redis;
        private bool disposed = false;
        public string InitKey = "UUIDkey";
        public long InitValue = 0L;

        public RedisUUID(RedisClient redis)
        {
            this.Redis = redis;
            Init();
        }

        public RedisUUID(RedisClient redis, string key, long value) : this(redis)
        {
            this.InitKey = key;
            this.InitValue = value;
        }

        private void Init()
        {
            var result = this.Redis.Exists(InitKey);
            if (!result) SetUUID(InitValue);
        }

        public void SetUUID(long value)
        {
            this.Redis.Set(InitKey, value);
        }

        public long GetUUID()
        {
            return this.Redis.Incr(InitKey);
        }

        public long[] GetUUID(int count)
        {
            var arry = new long[count];
            for (int i = 0; i < count; i++)
            {
                arry[i] = this.GetUUID();
            }
            return arry;
        }

        public string GetUUIDToString()
        {
            return this.Redis.Incr(InitKey).ToString();
        }

        public string GetUUIDToString(string format)
        {
            return this.Redis.Incr(InitKey).ToString(format);
        }

        public void SetExpire(int seconds)
        {
            this.Redis.Expire(InitKey, seconds);
        }

        public void SetExpireAt(DateTime dateTime)
        {
            this.Redis.ExpireAt(InitKey, dateTime);
        }

        public void Dispose()
        {
            Redis.Dispose();
        }

    }
}
