using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public static class ObjectExtension
    {
        /// <summary>
        /// Object转JObject
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static JObject ToJObject(this object obj)
        {
            return JObject.FromObject(obj);
        }

        /// <summary>
        /// Object转string
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToJson(this object obj, bool isformat = false)
        {
            var result = JObject.FromObject(obj);
            _ = result ?? throw new ArgumentNullException("obj转为jobj后为空");

            var format = isformat ? Formatting.Indented : Formatting.None;
            return result.ToString(format);
        }


    }
}
