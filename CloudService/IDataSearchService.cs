using NugetLibs.GaoDeMap.CloudModel;
using NugetLibs.GaoDeMap.HelpModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.CloudService
{
    /// <summary>
    /// 云图数据查询处理服务接口声明
    /// </summary>
    public interface IDataSearchService
    {
        /// <summary>
        /// 检索附近指定时间范围内（最大24小时）上报用户位置的位置信息
        /// </summary>
        /// <param name="nearbyData">当前附近参数</param>
        /// <returns>上报用户位置的位置信息JSON</returns>
        string AroundOriginalLocation(NearbyDataParam nearbyData);
        /// <summary>
        /// 检索附近指定时间范围内（最大24小时）上报用户位置的位置信息
        /// </summary>
        /// <param name="nearbyData">当前附近参数</param>
        /// <returns>上报用户位置的位置信息结果</returns>
        GaoDeBaseResult AroundLocation(NearbyDataParam nearbyData);

        /// <summary>
        /// 云图数据本地检索
        /// </summary>
        /// <param name="queryParam">本地检索参数</param>
        /// <returns>本地检索结果JSON</returns>
        string LocalOriginalQuery(LocalSearchParam queryParam);

        /// <summary>
        /// 云图数据本地检索
        /// </summary>
        /// <param name="queryParam">本地检索参数</param>
        /// <returns>本地检索结果对象</returns>
        DataSearchResult LocalQuery(LocalSearchParam queryParam);

        /// <summary>
        /// 云图数据周边检索
        /// </summary>
        /// <param name="queryParam">周边检索参数</param>
        /// <returns>周边检索结果JSON</returns>
        string AroundOriginalQuery(AroundSearchParam queryParam);

        /// <summary>
        /// 云图数据周边检索
        /// </summary>
        /// <param name="queryParam">周边检索参数</param>
        /// <returns>周边检索结果对象</returns>
        DataSearchResult AroundQuery(AroundSearchParam queryParam);

        /// <summary>
        /// 云图数据多边形检索
        /// </summary>
        /// <param name="queryParam">多边形检索参数</param>
        /// <returns>多边形检索结果JSON</returns>
        string PolygonOriginalQuery(PolygonSearchParam queryParam);

        /// <summary>
        /// 云图数据多边形检索
        /// </summary>
        /// <param name="queryParam">多边形检索参数</param>
        /// <returns>多边形检索结果对象</returns>
        DataSearchResult PolygonQuery(PolygonSearchParam queryParam);

        /// <summary>
        /// 云图数据id检索（poi详情检索）检索
        /// </summary>
        /// <param name="queryParam">id检索（poi详情检索）检索参数</param>
        /// <returns>id检索（poi详情检索）检索结果JSON</returns>
        string IDOriginalQuery(IDSearchParam queryParam);

        /// <summary>
        /// 云图数据id检索（poi详情检索）检索
        /// </summary>
        /// <param name="queryParam">id检索（poi详情检索）检索参数</param>
        /// <returns>id检索（poi详情检索）检索结果对象</returns>
        DataSearchResult IDQuery(IDSearchParam queryParam);

        /// <summary>
        /// 云图按条件检索数据（可遍历整表数据）
        /// </summary>
        /// <param name="queryParam">检索参数</param>
        /// <returns>检索结果JSON</returns>
        string AllOriginalQuery(AllSearchParam queryParam);

        /// <summary>
        /// 云图按条件检索数据（可遍历整表数据）
        /// </summary>
        /// <param name="queryParam">检索参数</param>
        /// <returns>检索结果对象</returns>
        DataSearchResult AllQuery(AllSearchParam queryParam);

        /// <summary>
        /// 云图省数据分布检索
        /// </summary>
        /// <param name="queryParam">省数据分布检索参数</param>
        /// <returns>省数据分布检索结果JSON</returns>
        string ProvinceOriginalQuery(ProvinceSearchParam queryParam);

        /// <summary>
        /// 云图省数据分布检索
        /// </summary>
        /// <param name="queryParam">省数据分布检索参数</param>
        /// <returns>省数据分布检索结果对象</returns>
        AreaSearchResult ProvinceQuery(ProvinceSearchParam queryParam);

        /// <summary>
        /// 云图市数据分布检索
        /// </summary>
        /// <param name="queryParam">市数据分布检索参数</param>
        /// <returns>市数据分布检索结果JSON</returns>
        string CityOriginalQuery(CitySearchParam queryParam);

        /// <summary>
        /// 云图市数据分布检索
        /// </summary>
        /// <param name="queryParam">市数据分布检索参数</param>
        /// <returns>市数据分布检索结果对象</returns>
        AreaSearchResult CityQuery(CitySearchParam queryParam);

        /// <summary>
        /// 云图区县数据分布检索
        /// </summary>
        /// <param name="queryParam">区县数据分布检索参数</param>
        /// <returns>区县数据分布检索结果JSON</returns>
        string DistrictOriginalQuery(DistrictSearchParam queryParam);

        /// <summary>
        /// 云图区县数据分布检索
        /// </summary>
        /// <param name="queryParam">区县数据分布检索参数</param>
        /// <returns>区县数据分布检索结果对象</returns>
        AreaSearchResult DistrictQuery(DistrictSearchParam queryParam);
    }
}
