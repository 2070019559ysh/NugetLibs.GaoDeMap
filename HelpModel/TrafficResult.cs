using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.HelpModel
{
    /// <summary>
    /// 交通态势响应结果
    /// </summary>
    public class TrafficResult : GaoDeBaseResult
    {
        /// <summary>
        /// 交通态势信息
        /// </summary>
        public TrafficInfo trafficinfo;
    }

    /// <summary>
    /// 交通态势信息
    /// </summary>
    public class TrafficInfo
    {
        /// <summary>
        /// 路况综述
        /// </summary>
        public string description;
        /// <summary>
        /// 路况评价
        /// </summary>
        public Evaluation evaluation;
        /// <summary>
        /// 道路交通信息集合，当extensions=all时返回
        /// </summary>
        public List<RoadTraffic> roads;
    }

    /// <summary>
    /// 路况评价
    /// </summary>
    public class Evaluation
    {
        /// <summary>
        /// 畅通所占百分比
        /// </summary>
        public string expedite;
        /// <summary>
        /// 缓行所占百分比
        /// </summary>
        public string congested;
        /// <summary>
        /// 拥堵所占百分比
        /// </summary>
        public string blocked;
        /// <summary>
        /// 未知路段所占百分比
        /// </summary>
        public string unknown;
        /// <summary>
        /// 路况
        /// <para>0：未知，1：畅通，2：缓行，3：拥堵</para>
        /// </summary>
        public int status;
    }

    /// <summary>
    /// 道路交通情况
    /// </summary>
    public class RoadTraffic
    {
        /// <summary>
        /// 道路名称
        /// </summary>
        public string name;
        /// <summary>
        /// 路况
        /// <para>0：未知，1：畅通，2：缓行，3：拥堵</para>
        /// </summary>
        public int status;
        /// <summary>
        /// 方向描述
        /// </summary>
        public string direction;
        /// <summary>
        /// 车行角度，判断道路正反向使用
        /// <para>以正东方向为0度，逆时针方向为正，取值范围：[0,360]</para>
        /// </summary>
        public int angle;
        /// <summary>
        /// 速度，单位：千米/小时
        /// </summary>
        public string speed;
        /// <summary>
        /// locationcode的集合，是道路中某一段的id，一条路包括多个locationcode
        /// <para>angle在[0-180]之间取正值，[181-359]之间取负值</para>
        /// </summary>
        public string lcodes;
        /// <summary>
        /// 道路坐标集，坐标集合
        /// <para>经度和纬度使用","分隔，坐标之间使用";"分隔。例如：x1,y1;x2,y2</para>
        /// </summary>
        public string polyline;
    }
}
