using NugetLibs.GaoDeMap.HelpModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.WebService
{
    /// <summary>
    /// 行政区域处理服务接口声明
    /// </summary>
    public interface IAdminRegionService
    {
        /// <summary>
        /// 行政区域查询
        /// </summary>
        /// <param name="queryParam">查询区域参数</param>
        /// <returns>行政区域查询结果</returns>
        string QueryOriginalAdminRegion(AdminRegionQueryParam queryParam);

        /// <summary>
        /// 行政区域查询
        /// </summary>
        /// <param name="queryParam">查询区域参数</param>
        /// <returns>行政区域查询结果</returns>
        AdminRegionQueryResult QueryAdminRegion(AdminRegionQueryParam queryParam);
    }
}
