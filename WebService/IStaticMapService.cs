using NugetLibs.GaoDeMap.HelpModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NugetLibs.GaoDeMap.WebService
{
    /// <summary>
    /// 静态地图的处理服务接口声明
    /// </summary>
    public interface IStaticMapService
    {
        /// <summary>
        /// 获取静态地图
        /// </summary>
        /// <param name="queryParam">查询参数</param>
        /// <param name="contentType">输出图片内容类型</param>
        /// <returns>静态地图缓存流</returns>
        MemoryStream GetOriginalMap(StaticMapParam queryParam, out string contentType);
    }
}
