using NugetLibs.GaoDeMap.HelpModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.WebService
{
    /// <summary>
    /// 地理/逆地理编码处理服务接口声明
    /// </summary>
    public interface IGeographyService
    {
        /// <summary>
        /// 获取地理编码原始数据信息
        /// </summary>
        /// <param name="geoCodeParam">地理编码所需参数</param>
        /// <returns>地理编码信息</returns>
        string GetOriginalGeoCode(GeoCodeParam geoCodeParam);

        /// <summary>
        /// 获取地理编码信息
        /// </summary>
        /// <param name="geoCodeParam">地理编码所需参数</param>
        /// <returns>地理编码信息</returns>
        GeoCodeResult GetGeoCode(GeoCodeParam geoCodeParam);

        /// <summary>
        /// 获取逆地理编码原始数据信息
        /// </summary>
        /// <param name="reGeoCodeParam">逆地理编码所需参数</param>
        /// <returns>逆地理编码信息</returns>
        string GetOriginalGeoDecode(GeoDecodeParam geoDecodeParam);

        /// <summary>
        /// 获取逆地理编码信息
        /// </summary>
        /// <param name="reGeoCodeParam">逆地理编码所需参数</param>
        /// <returns>逆地理编码信息</returns>
        GeoDecodeResult GetGeoDecode(GeoDecodeParam geoDecodeParam);
    }
}
