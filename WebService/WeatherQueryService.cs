using NugetLibs.HelpTool;
using NugetLibs.GaoDeMap.HelpModel;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace NugetLibs.GaoDeMap.WebService
{
    /// <summary>
    /// 天气查询数据处理服务
    /// </summary>
    public class WeatherQueryService : IWeatherQueryService
    {
        /// <summary>
        /// 查询天气信息
        /// </summary>
        /// <param name="queryParam">查询参数</param>
        /// <returns>城市的天气结果</returns>
        public string SearchOriginalWeather(SkyCityParam queryParam)
        {
            string getUrl = GaoDeConst.WebAPIHost + "/v3/weather/weatherInfo?{0}";
            string paras = queryParam.GenerateParams();
            getUrl = string.Format(getUrl, paras);
            string queryResult = WebRequestHelper.HttpGet(getUrl);
            return queryResult;
        }

        /// <summary>
        /// 查询天气信息
        /// </summary>
        /// <param name="queryParam">查询参数</param>
        /// <returns>城市的天气结果</returns>
        public WeatherResult SearchWeather(SkyCityParam queryParam)
        {
            queryParam.output = "JSON";
            string jsonResult = SearchOriginalWeather(queryParam);
            if (!string.IsNullOrWhiteSpace(jsonResult))
            {
                jsonResult = jsonResult.Replace("[]", "\"\"");
            }
            WeatherResult queryResult = JsonConvert.DeserializeObject<WeatherResult>(jsonResult);
            return queryResult;
        }
    }
}
