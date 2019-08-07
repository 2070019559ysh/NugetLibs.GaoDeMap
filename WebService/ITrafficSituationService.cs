using NugetLibs.GaoDeMap.HelpModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.WebService
{
    /// <summary>
    /// 交通态势查询处理服务接口声明
    /// </summary>
    public interface ITrafficSituationService
    {
        /// <summary>
        /// 查询交通态势信息
        /// </summary>
        /// <param name="queryParam">查询参数</param>
        /// <returns>交通态势信息</returns>
        string SearchOriginalTraffic(TrafficParam queryParam);

        /// <summary>
        /// 查询交通态势信息
        /// </summary>
        /// <param name="queryParam">查询参数</param>
        /// <returns>交通态势信息</returns>
        TrafficResult SearchTraffic(TrafficParam queryParam);
    }
}
