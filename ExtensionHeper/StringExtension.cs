using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public static class StringExtension
    {
        /// <summary>
        /// String转JObject
        /// </summary>
        /// <returns></returns>
        public static JObject ToJObject(this string json)
        {
            return JObject.Parse(json);
        }

    }
}
