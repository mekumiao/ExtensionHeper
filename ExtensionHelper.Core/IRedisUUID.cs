using System;

namespace ExtensionHeper
{
    public interface IRedisUUID
    {
        void SetUUID(long value);
        long GetUUID();
        long[] GetUUID(int count);
        string GetUUIDToString();
        string GetUUIDToString(string key);
        void SetExpire(int seconds);
        void SetExpireAt(DateTime dateTime);
    }
}