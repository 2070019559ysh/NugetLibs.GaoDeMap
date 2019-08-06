using NugetLibs.GaoDeMap.HelpModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.WebService
{
    /// <summary>
    /// 天气查询数据处理服务接口声明
    /// </summary>
    public interface IWeatherQueryService
    {
        /// <summary>
        /// 查询天气信息
        /// </summary>
        /// <param name="queryParam">查询参数</param>
        /// <returns>城市的天气结果</returns>
        string SearchOriginalWeather(SkyCityParam queryParam);

        /// <summary>
        /// 查询天气信息
        /// </summary>
        /// <param name="queryParam">查询参数</param>
        /// <returns>城市的天气结果</returns>
        WeatherResult SearchWeather(SkyCityParam queryParam);
    }
}
