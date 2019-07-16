using NugetLibs.HelpTool;
using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.HelpModel
{
    /// <summary>
    /// 高德请求参数基类
    /// </summary>
    public abstract class GaoDeBaseParam
    {
        /// <summary>
        /// 高德Key，必填
        /// </summary>
        public string key = GaoDeConfig.AppKey;
        /// <summary>
        /// 数字签名，可选
        /// <para>MD5(请求参数键值对（按参数名的升序排序），加（请注意“加”字无需输入）私钥)</para>
        /// </summary>
        public string sign;
        /// <summary>
        /// 返回数据格式类型，可选
        /// <para>可选输入内容包括：JSON，XML。设置 JSON 返回结果数据将会以JSON结构构成；
        /// 如果设置 XML 返回结果数据将以 XML 结构构成。</para>
        /// </summary>
        public string output = "JSON";
        /// <summary>
        /// 回调函数，可选
        /// <para>callback 值是用户定义的函数名称，此参数只在 output 参数设置为 JSON 时有效。</para>
        /// </summary>
        public string callback;

        /// <summary>
        /// 生成实例对象对应的查询字符串参数
        /// </summary>
        /// <returns>查询字符串参数</returns>
        public string GenerateParams()
        {
            Type thisType = this.GetType();
            this.sign = null;//首次转换查询字符串要忽略数字签名
            string paras = QueryHelper.ToQueryString(this, thisType);
            if (!string.IsNullOrWhiteSpace(GaoDeConfig.SignSecret))
            {
                paras = QueryHelper.QueryStringSort(paras);//查询字符串排序生成签名后再插入数字签名
                this.sign = EncryptHelper.HashMD5(paras + GaoDeConfig.SignSecret);
                paras = QueryHelper.ToQueryString(this, thisType);
            }
            return paras;
        }

        /// <summary>
        /// 输出对象对应的查询字符串参数
        /// </summary>
        /// <returns>查询字符串参数</returns>
        public override string ToString()
        {
            return GenerateParams();
        }
    }
}
