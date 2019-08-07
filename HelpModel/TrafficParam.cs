using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.HelpModel
{
    /// <summary>
    /// 交通态势查询基础参数
    /// </summary>
    public abstract class TrafficParam : GaoDeBaseParam
    {
        /// <summary>
        /// 道路等级，可选
        /// <para>1：高速（京藏高速）2：城市快速路、国道（西三环、103国道）3：高速辅路（G6辅路）</para>
        /// <para>4：主要道路（长安街、三环辅路路）5：一般道路（彩和坊路）6：无名道路</para>
        /// </summary>
        public int level = 5;
        /// <summary>
        /// 返回结果控制，可选
        /// <para>可选值：base,all</para>
        /// </summary>
        public string extensions;
    }

    /// <summary>
    /// 矩形区域交通态势查询参数
    /// </summary>
    public class TrafficRectangleParam : TrafficParam
    {
        /// <summary>
        /// 矩形区域查询（左下右上顶点坐标对），必填
        /// <para>矩形对角线不能超过10公里，两个坐标对之间用”;”间隔，xy之间用”,”间隔</para>
        /// </summary>
        public string rectangle;
    }

    /// <summary>
    /// 圆形区域交通态势查询参数
    /// </summary>
    public class TrafficCircleParam : TrafficParam
    {
        /// <summary>
        /// 中心点坐标，必填
        /// <para>经度在前，纬度在后。经度和纬度用","分割；经纬度小数点后不得超过6位</para>
        /// </summary>
        public string location;
        /// <summary>
        /// 半径，可选
        /// <para>单位：米，最大取值5000米</para>
        /// </summary>
        public int radius = 1000;
    }

    /// <summary>
    /// 指定线路交通态势查询参数
    /// </summary>
    public class TrafficRoadParam : TrafficParam
    {
        /// <summary>
        /// 道路名，必填
        /// </summary>
        public string name;
        /// <summary>
        /// 城市名，非必填（city和adcode必填一个）
        /// <para>（开发者称呼为深圳，但高德仅识别深圳市）故强烈建议使用adcode，不使用city字段</para>
        /// </summary>
        public string city;
        /// <summary>
        /// 城市编码，非必填（city和adcode必填一个）
        /// <para>adcode仅识别市级的adcode</para>
        /// </summary>
        public string adcode;
    }
}
