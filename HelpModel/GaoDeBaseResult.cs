using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.HelpModel
{
    /// <summary>
    /// 高德响应结果基类
    /// </summary>
    public class GaoDeBaseResult
    {
        /// <summary>
        /// 结果状态值：返回值为 0 或 1，0 表示请求失败；1 表示请求成功
        /// </summary>
        public int status;
        /// <summary>
        /// 返回状态说明：当 status 为 0 时，info 会返回具体错误原因，否则返回“OK”
        /// </summary>
        public string info;
        /// <summary>
        /// 返回状态码，10000代表正确
        /// </summary>
        public string infocode;
    }
}
