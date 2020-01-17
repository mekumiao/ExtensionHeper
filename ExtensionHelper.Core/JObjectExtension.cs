using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newtonsoft.Json.Linq
{
    public static class JObjectExtension
    {
        /// <summary>
        /// 获取 jobject内部字段值
        /// </summary>
        /// <param name="jobj"></param>
        /// <param name="prm">参数示例："key1","key2","key3", 2</param>
        /// <returns></returns>
        public static JToken GetToken(this JObject jobj, params object[] prm)
        {
            return GetToken_dg(jobj, 0, prm);
        }

        /// <summary>
        /// 递归获取值
        /// </summary>
        /// <param name="token"></param>
        /// <param name="index"></param>
        /// <param name="prm"></param>
        /// <returns></returns>
        private static JToken GetToken_dg(JToken token, int index, params object[] prm)
        {
            JToken tk = token[prm[index++]];
            if (index < prm.Length)
            {
                tk = GetToken_dg(tk, index, prm);
            }
            return tk;
        }

    }
}
