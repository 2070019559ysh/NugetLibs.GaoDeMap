using Newtonsoft.Json;
using NugetLibs.GaoDeMap.HelpModel;
using NugetLibs.HelpTool;
using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.WebService
{
    /// <summary>
    /// 行政区域处理服务
    /// </summary>
    public class AdminRegionService : IAdminRegionService
    {
        /// <summary>
        /// 行政区域查询
        /// </summary>
        /// <param name="queryParam">查询区域参数</param>
        /// <returns>行政区域查询结果</returns>
        public string QueryOriginalAdminRegion(AdminRegionQueryParam queryParam)
        {
            string getUrl = "https://restapi.amap.com/v3/config/district?{0}";
            string paras = queryParam.GenerateParams();
            getUrl = string.Format(getUrl, paras);
            string queryResult = WebRequestHelper.HttpGet(getUrl);
            return queryResult;
        }

        /// <summary>
        /// 行政区域查询
        /// </summary>
        /// <param name="queryParam">查询区域参数</param>
        /// <returns>行政区域查询结果</returns>
        public AdminRegionQueryResult QueryAdminRegion(AdminRegionQueryParam queryParam)
        {
            queryParam.output = "JSON";
            string jsonResult = QueryOriginalAdminRegion(queryParam);
            if (!string.IsNullOrWhiteSpace(jsonResult))
            {
                jsonResult = jsonResult.Replace("[]", "\"\"");
            }
            AdminRegionQueryResult queryResult = JsonConvert.DeserializeObject<AdminRegionQueryResult>(jsonResult);
            return queryResult;
        }
    }
}
