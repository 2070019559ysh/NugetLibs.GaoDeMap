using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.HelpModel
{
    /// <summary>
    /// 公交路径规划请求参数
    /// </summary>
    public class TransitPlanParam : GaoDeBaseParam
    {
        /// <summary>
        /// 出发点，必填
        /// <para>规则：lon，lat（经度，纬度）， “,”分割，如117.500244, 40.417801 经纬度小数点不超过6位</para>
        /// </summary>
        public string origin;
        /// <summary>
        /// 目的地，必填
        /// <para>规则：lon，lat（经度，纬度）， “,”分割，如117.500244, 40.417801 经纬度小数点不超过6位</para>
        /// </summary>
        public string destination;
        /// <summary>
        /// 城市/跨城规划时的起点城市，必填
        /// <para>可选值：城市名称/citycode</para>
        /// </summary>
        public string city;
        /// <summary>
        /// 跨城公交规划时的终点城市，可选（跨城必填 ）
        /// <para>可选值：城市名称/citycode</para>
        /// </summary>
        public string cityd;
        /// <summary>
        /// 返回结果详略，可选
        /// <para>base:返回基本信息；all：返回全部信息</para>
        /// </summary>
        public string extensions;
        /// <summary>
        /// 公交换乘策略，可选(0：最快捷模式;1：最经济模式;2：最少换乘模式;3：最少步行模式;5：不乘地铁模式)，与GaoDeConst.transitStrategy对应
        /// </summary>
        public int strategy;
        /// <summary>
        /// 是否计算夜班车，可选
        /// <para>可选值：0：不计算夜班车 1：计算夜班车</para>
        /// </summary>
        public int nightflag;
        /// <summary>
        /// 出发日期，可选
        /// <para>根据出发时间和日期（未来时间点）筛选可乘坐的公交路线，格式：date=2014-3-19</para>
        /// </summary>
        public string date;
        /// <summary>
        /// 出发时间，可选
        /// <para>根据出发时间和日期（未来时间点）筛选可乘坐的公交路线，格式：time=22:34</para>
        /// </summary>
        public string time;
    }
}
