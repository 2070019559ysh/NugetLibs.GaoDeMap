using Newtonsoft.Json;
using NugetLibs.GaoDeMap.HelpModel;
using NugetLibs.HelpTool;
using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.WebService
{
    /// <summary>
    /// 地理/逆地理编码处理服务
    /// </summary>
    public class GeographyService : IGeographyService
    {
        /// <summary>
        /// 获取地理编码原始数据信息
        /// </summary>
        /// <param name="geoCodeParam">地理编码所需参数</param>
        /// <returns>地理编码信息</returns>
        public string GetOriginalGeoCode(GeoCodeParam geoCodeParam)
        {
            string getUrl = GaoDeConst.WebAPIHost + "/v3/geocode/geo?{0}";
            string paras = geoCodeParam.GenerateParams();
            getUrl = string.Format(getUrl, paras);
            string geoCodeResult = WebRequestHelper.HttpGet(getUrl);
            return geoCodeResult;
        }

        /// <summary>
        /// 获取地理编码信息
        /// </summary>
        /// <param name="geoCodeParam">地理编码所需参数</param>
        /// <returns>地理编码信息</returns>
        public GeoCodeResult GetGeoCode(GeoCodeParam geoCodeParam)
        {
            geoCodeParam.output = "JSON";
            string jsonResult = GetOriginalGeoCode(geoCodeParam);
            if (!string.IsNullOrWhiteSpace(jsonResult))
            {
                jsonResult = jsonResult.Replace("[]", "\"\"");
            }
            GeoCodeResult geoCodeResult = JsonConvert.DeserializeObject<GeoCodeResult>(jsonResult);
            return geoCodeResult;
        }

        /// <summary>
        /// 获取逆地理编码原始数据信息
        /// </summary>
        /// <param name="reGeoCodeParam">逆地理编码所需参数</param>
        /// <returns>逆地理编码信息</returns>
        public string GetOriginalGeoDecode(GeoDecodeParam geoDecodeParam)
        {
            string getUrl = GaoDeConst.WebAPIHost + "/v3/geocode/regeo?{0}";
            string paras = geoDecodeParam.GenerateParams();
            getUrl = string.Format(getUrl, paras);
            string geoDecodeResult = WebRequestHelper.HttpGet(getUrl);
            return geoDecodeResult;
        }

        /// <summary>
        /// 获取逆地理编码信息
        /// </summary>
        /// <param name="reGeoCodeParam">逆地理编码所需参数</param>
        /// <returns>逆地理编码信息</returns>
        public GeoDecodeResult GetGeoDecode(GeoDecodeParam geoDecodeParam)
        {
            geoDecodeParam.output = "JSON";
            string jsonResult = GetOriginalGeoDecode(geoDecodeParam);
            if (!string.IsNullOrWhiteSpace(jsonResult))
            {
                jsonResult = jsonResult.Replace("[]", "\"\"");
            }
            GeoDecodeResult geoDecodeResult = JsonConvert.DeserializeObject<GeoDecodeResult>(jsonResult);
            return geoDecodeResult;
        }
    }
}
