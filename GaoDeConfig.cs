using System;

namespace NugetLibs.GaoDeMap
{
    /// <summary>
    /// 高德地图全局默认配置信息
    /// </summary>
    public class GaoDeConfig
    {
        /// <summary>
        /// 授权访问的Key
        /// </summary>
        public static string AppKey { get; set; }
        /// <summary>
        /// 生成数字签名的密钥，为空则不进行数字签名
        /// </summary>
        public static string SignSecret { get; set; }
    }
}
