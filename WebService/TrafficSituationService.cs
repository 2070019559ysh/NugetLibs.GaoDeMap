using Newtonsoft.Json;
using NugetLibs.GaoDeMap.HelpModel;
using NugetLibs.HelpTool;
using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.WebService
{
    /// <summary>
    /// 交通态势查询处理服务
    /// </summary>
    public class TrafficSituationService : ITrafficSituationService
    {
        /// <summary>
        /// 查询交通态势信息
        /// </summary>
        /// <param name="queryParam">查询参数</param>
        /// <returns>交通态势信息</returns>
        public string SearchOriginalTraffic(TrafficParam queryParam)
        {
            string getUrl = GaoDeConst.WebAPIHost;
            if (queryParam is TrafficRectangleParam)
                getUrl += WebAPI.RECTANGLE_TRAFFIC;
            else if (queryParam is TrafficCircleParam)
                getUrl += WebAPI.CIRCLE_TRAFFIC;
            else
                getUrl += WebAPI.ROAD_TRAFFIC;
            getUrl += "?{0}";
            string paras = queryParam.GenerateParams();
            getUrl = string.Format(getUrl, paras);
            string queryResult = WebRequestHelper.HttpGet(getUrl);
            return queryResult;
        }

        /// <summary>
        /// 查询交通态势信息
        /// </summary>
        /// <param name="queryParam">查询参数</param>
        /// <returns>交通态势信息</returns>
        public TrafficResult SearchTraffic(TrafficParam queryParam)
        {
            queryParam.output = "JSON";
            string jsonResult = SearchOriginalTraffic(queryParam);
            if (!string.IsNullOrWhiteSpace(jsonResult))
            {
                jsonResult = jsonResult.Replace("[]", "\"\"");
            }
            TrafficResult queryResult = JsonConvert.DeserializeObject<TrafficResult>(jsonResult);
            return queryResult;
        }
    }
}
