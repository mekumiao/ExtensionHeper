using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Collections.Generic
{
    /// <summary>
    /// 枚举器、集合 遍历扩展
    /// </summary>
    public static class EnumerableExtension
    {
        public static void ForEach<TSource>(this IEnumerable<TSource> source, Action<TSource> action)
        {
            foreach (var item in source)
            {
                action.Invoke(item);
            }
        }

        public static void ForEach<TSource>(this IEnumerable<TSource> source, Action<TSource, int> action)
        {
            var index = 0;
            foreach (var item in source)
            {
                action.Invoke(item, index);
                ++index;
            }
        }

        public static void ForEach<TSource>(this List<TSource> source, Action<TSource, int> action)
        {
            var index = 0;
            foreach (var item in source)
            {
                action.Invoke(item, index);
                ++index;
            }
        }
    }
}
