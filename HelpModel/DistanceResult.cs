using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.HelpModel
{
    /// <summary>
    /// 距离测量结果
    /// </summary>
    public class DistanceResult : GaoDeBaseResult
    {
        /// <summary>
        /// 距离信息列表
        /// </summary>
        public List<DistanceInfo> results;
    }

    /// <summary>
    /// 距离基本信息
    /// </summary>
    public class DistanceInfo
    {
        /// <summary>
        /// 起点坐标，起点坐标序列号（从1开始）
        /// </summary>
        public int origin_id;
        /// <summary>
        /// 终点坐标，终点坐标序列号（从1开始）
        /// </summary>
        public int dest_id;
        /// <summary>
        /// 路径距离，单位：米
        /// </summary>
        public int distance;
        /// <summary>
        /// 预计行驶时间，单位：秒
        /// </summary>
        public int duration;
        /// <summary>
        /// 仅在出错的时候显示该字段
        /// <para>由于此接口支持批量请求，建议不论批量与否用此字段判断请求是否成功</para>
        /// </summary>
        public string info;
        /// <summary>
        /// 仅在出错的时候显示此字段
        /// <para>在驾车模式下：1=指定地点之间没有可以行车的道路，2=起点/终点 距离所有道路均距离过远（例如在海洋/矿业）3=起点/终点不在中国境内</para>
        /// </summary>
        public int code;
    }
}
