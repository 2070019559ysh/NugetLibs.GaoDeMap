using NugetLibs.HelpTool;
using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.CloudModel
{
    /// <summary>
    /// 云图服务基础参数
    /// </summary>
    public class CloudBaseParam
    {
        /// <summary>
        /// 高德Key，必填
        /// </summary>
        public string key = GaoDeConfig.AppKey;
        /// <summary>
        /// 数字签名，可选
        /// <para>MD5(请求参数键值对（按参数名的升序排序），加（请注意“加”字无需输入）私钥)</para>
        /// </summary>
        public string sig;

        /// <summary>
        /// 生成实例对象对应的查询字符串参数
        /// </summary>
        /// <returns>查询字符串参数</returns>
        public Dictionary<string,string> GenerateParams()
        {
            Type thisType = this.GetType();
            this.sig = null;//首次转换查询字符串要忽略数字签名
            string paras = QueryHelper.ToQueryString(this, thisType);
            if (!string.IsNullOrWhiteSpace(GaoDeConfig.SignSecret))
            {
                paras = QueryHelper.QueryStringSort(paras);//查询字符串排序生成签名后再插入数字签名
                this.sig = EncryptHelper.HashMD5(paras + GaoDeConfig.SignSecret);
            }
            return QueryHelper.ToDictionary(this, thisType);
        }
    }
}
