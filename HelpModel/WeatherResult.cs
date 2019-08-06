using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.HelpModel
{
    /// <summary>
    /// 天气结果
    /// </summary>
    public class WeatherResult : GaoDeBaseResult
    {
        /// <summary>
        /// 返回结果总数目
        /// </summary>
        public int count;
        /// <summary>
        /// 实况天气数据信息
        /// </summary>
        public List<WeatherLive> lives;
        /// <summary>
        /// 预报天气信息数据
        /// </summary>
        public List<WeatherForecast> forecasts;
    }

    /// <summary>
    /// 实况天气数据信息
    /// </summary>
    public class WeatherLive
    {
        /// <summary>
        /// 省份名
        /// </summary>
        public string province;
        /// <summary>
        /// 城市名
        /// </summary>
        public string city;
        /// <summary>
        /// 区域编码
        /// </summary>
        public string adcode;
        /// <summary>
        /// 天气现象（汉字描述）
        /// </summary>
        public string weather;
        /// <summary>
        /// 实时气温，单位：摄氏度
        /// </summary>
        public int temperature;
        /// <summary>
        /// 风向描述
        /// </summary>
        public string winddirection;
        /// <summary>
        /// 风力级别，单位：级
        /// </summary>
        public string windpower;
        /// <summary>
        /// 空气湿度
        /// </summary>
        public int humidity;
        /// <summary>
        /// 数据发布的时间
        /// </summary>
        public DateTime reporttime;
    }

    /// <summary>
    /// 预报天气信息数据
    /// </summary>
    public class WeatherForecast
    {
        /// <summary>
        /// 省份名
        /// </summary>
        public string province;
        /// <summary>
        /// 城市名
        /// </summary>
        public string city;
        /// <summary>
        /// 区域编码
        /// </summary>
        public string adcode;
        /// <summary>
        /// 数据发布的时间
        /// </summary>
        public DateTime reporttime;
        /// <summary>
        /// 天气预报数据
        /// <para>按顺序为当天、第二天、第三天的预报数据</para>
        /// </summary>
        public List<CastInfo> casts;
    }

    /// <summary>
    /// 天气预报数据
    /// </summary>
    public class CastInfo
    {
        /// <summary>
        /// 日期
        /// </summary>
        public string date;
        /// <summary>
        /// 星期几[1-7]
        /// </summary>
        public int week;
        /// <summary>
        /// 白天天气现象
        /// </summary>
        public string dayweather;
        /// <summary>
        /// 晚上天气现象
        /// </summary>
        public string nightweather;
        /// <summary>
        /// 白天温度
        /// </summary>
        public int daytemp;
        /// <summary>
        /// 晚上温度
        /// </summary>
        public int nighttemp;
        /// <summary>
        /// 白天风向
        /// </summary>
        public string daywind;
        /// <summary>
        /// 晚上风向
        /// </summary>
        public string nightwind;
        /// <summary>
        /// 白天风力
        /// </summary>
        public string daypower;
        /// <summary>
        /// 晚上风力
        /// </summary>
        public string nightpower;
    }
}
