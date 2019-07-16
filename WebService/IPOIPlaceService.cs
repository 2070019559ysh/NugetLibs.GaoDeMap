using NugetLibs.GaoDeMap.HelpModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.WebService
{
    /// <summary>
    /// 搜索POI处理服务接口声明
    /// </summary>
    public interface IPOIPlaceService
    {
        /// <summary>
        /// 关键字搜索POI信息
        /// </summary>
        /// <param name="queryParam">查询参数</param>
        /// <returns>搜索POI查询结果</returns>
        string SearchOriginalPOIByText(POITextParam queryParam);

        /// <summary>
        /// 关键字搜索POI信息
        /// </summary>
        /// <param name="queryParam">查询参数</param>
        /// <returns>搜索POI查询结果</returns>
        POIPlaceResult SearchPOIByText(POITextParam queryParam);

        /// <summary>
        /// 周边搜索POI信息
        /// </summary>
        /// <param name="queryParam">查询参数</param>
        /// <returns>搜索POI查询结果</returns>
        string SearchOriginalPOIByAround(POIAroundParam queryParam);

        /// <summary>
        /// 周边搜索POI信息
        /// </summary>
        /// <param name="queryParam">查询参数</param>
        /// <returns>搜索POI查询结果</returns>
        POIPlaceResult SearchPOIByAround(POIAroundParam queryParam);

        /// <summary>
        /// 多边形搜索POI信息
        /// </summary>
        /// <param name="queryParam">查询参数</param>
        /// <returns>搜索POI查询结果</returns>
        string SearchOriginalPOIByPolygon(POIPolygonParam queryParam);

        /// <summary>
        /// 多边形搜索POI信息
        /// </summary>
        /// <param name="queryParam">查询参数</param>
        /// <returns>搜索POI查询结果</returns>
        POIPlaceResult SearchPOIByPolygon(POIPolygonParam queryParam);

        /// <summary>
        /// ID查询POI信息
        /// </summary>
        /// <param name="queryParam">查询参数</param>
        /// <returns>搜索POI查询结果</returns>
        string SearchOriginalPOIByDetail(POIDetailParam queryParam);

        /// <summary>
        /// ID查询POI信息
        /// </summary>
        /// <param name="queryParam">查询参数</param>
        /// <returns>搜索POI查询结果</returns>
        POIPlaceResult SearchPOIByDetail(POIDetailParam queryParam);
    }
}
