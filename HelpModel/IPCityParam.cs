using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.HelpModel
{
    /// <summary>
    /// IP城市位置查询的参数
    /// </summary>
    public class IPCityParam : GaoDeBaseParam
    {
        /// <summary>
        /// ip地址
        /// <para>需要搜索的IP地址（仅支持国内）若用户不填写IP，则取客户http之中的请求来进行定位</para>
        /// </summary>
        public string ip;
    }
}
