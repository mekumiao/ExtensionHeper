using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionHeper
{
    public class TimeStampHelper
    {
        public static DateTime startTime { get; } = new DateTime(1970, 1, 1, 0, 0, 0, 0);

        /// <summary>
        /// 获取时间戳，秒单位
        /// </summary>
        /// <returns></returns>
        public static long GetTSByss()
        {
            var ts = DateTime.UtcNow - startTime;
            return Convert.ToInt64(ts.TotalSeconds);
        }

        public static long GetTSByss(DateTime dateTime)
        {
            var ts = dateTime - startTime;
            return Convert.ToInt64(ts.TotalSeconds);
        }

        public static long GetTsByss(long ticks)
        {
            var ts = new DateTime(ticks) - startTime;
            return Convert.ToInt64(ts);
        }

        /// <summary>
        /// 获取时间戳，毫秒单位
        /// </summary>
        /// <returns></returns>
        public static long GetTSBymm()
        {
            var ts = DateTime.UtcNow - startTime;
            return Convert.ToInt64(ts.TotalMilliseconds);
        }

        public static long GetTSBymm(DateTime dateTime)
        {
            var ts = dateTime - startTime;
            return Convert.ToInt64(ts.TotalMilliseconds);
        }

        public static long GetTSBymm(long ticks)
        {
            var ts = new DateTime(ticks) - startTime;
            return Convert.ToInt64(ts.TotalMilliseconds);
        }
    }
}
