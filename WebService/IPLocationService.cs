using Newtonsoft.Json;
using NugetLibs.GaoDeMap.HelpModel;
using NugetLibs.HelpTool;
using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.WebService
{
    /// <summary>
    /// IP定位处理服务
    /// </summary>
    public class IPLocationService : IIPLocationService
    {
        /// <summary>
        /// 获取IP所在的城市位置信息
        /// </summary>
        /// <param name="queryParam">查询参数</param>
        /// <returns>IP所在城市位置信息</returns>
        public string GetOriginalIPCity(IPCityParam queryParam)
        {
            string getUrl = "https://restapi.amap.com/v3/ip?{0}";
            string paras = queryParam.GenerateParams();
            getUrl = string.Format(getUrl, paras);
            string geoCodeResult = WebRequestHelper.HttpGet(getUrl);
            return geoCodeResult;
        }

        /// <summary>
        /// 获取IP对应的城市位置信息
        /// </summary>
        /// <param name="queryParam">地理编码所需参数</param>
        /// <returns>IP所在城市位置信息</returns>
        public IPCityResult GetIPCity(IPCityParam queryParam)
        {
            queryParam.output = "JSON";
            string jsonResult = GetOriginalIPCity(queryParam);
            if (!string.IsNullOrWhiteSpace(jsonResult))
            {
                jsonResult = jsonResult.Replace("[]", "\"\"");
            }
            IPCityResult queryResult = JsonConvert.DeserializeObject<IPCityResult>(jsonResult);
            return queryResult;
        }
    }
}
