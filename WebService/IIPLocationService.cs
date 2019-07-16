using NugetLibs.GaoDeMap.HelpModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.WebService
{
    /// <summary>
    /// IP定位处理服务接口声明
    /// </summary>
    public interface IIPLocationService
    {
        /// <summary>
        /// 获取IP所在的城市位置信息
        /// </summary>
        /// <param name="queryParam">查询参数</param>
        /// <returns>IP所在城市位置信息</returns>
        string GetOriginalIPCity(IPCityParam queryParam);

        /// <summary>
        /// 获取IP对应的城市位置信息
        /// </summary>
        /// <param name="queryParam">地理编码所需参数</param>
        /// <returns>IP所在城市位置信息</returns>
        IPCityResult GetIPCity(IPCityParam queryParam);
    }
}
