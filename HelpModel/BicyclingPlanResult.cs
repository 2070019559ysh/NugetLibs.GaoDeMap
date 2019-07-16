using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.HelpModel
{
    /// <summary>
    /// 骑行路径规划响应结果
    /// </summary>
    public class BicyclingPlanResult
    {
        /// <summary>
        /// 返回结果码，0，表示成功
        /// </summary>
        public int errcode;
        /// <summary>
        /// 具体错误原因
        /// <para>此字段会详细说明错误原因</para>
        /// </summary>
        public string errdetail;
        /// <summary>
        /// 返回状态说明，OK代表成功
        /// </summary>
        public string errmsg;
        /// <summary>
        /// 骑行路径规划具体内容
        /// </summary>
        public BicyclingData data;
    }

    /// <summary>
    /// 骑行路径规划具体数据
    /// </summary>
    public class BicyclingData
    {
        /// <summary>
        /// 起点坐标，格式:X,Y
        /// </summary>
        public string origin;
        /// <summary>
        /// 终点坐标，格式:X,Y
        /// </summary>
        public string destination;
        /// <summary>
        /// 骑行方案列表信息
        /// </summary>
        public List<BicyclingPathInfo> paths;
    }

    /// <summary>
    /// 骑行方案信息
    /// </summary>
    public class BicyclingPathInfo
    {
        /// <summary>
        /// 起终点的骑行距离，单位：米
        /// </summary>
        public int distance;
        /// <summary>
        /// 起终点的骑行时间，单位：秒
        /// </summary>
        public int duration;
        /// <summary>
        /// 具体骑行结果
        /// </summary>
        public List<BicyclingStepInfo> steps;
    }

    /// <summary>
    /// 骑行行驶步骤信息
    /// </summary>
    public class BicyclingStepInfo
    {
        /// <summary>
        /// 路段骑行指示，例如：“骑行54米右转”
        /// </summary>
        public string instruction;
        /// <summary>
        /// 此段路道路名称
        /// </summary>
        public string road;
        /// <summary>
        /// 此段路骑行距离，单位：米
        /// </summary>
        public int distance;
        /// <summary>
        /// 此段路骑行耗时，单位：秒
        /// </summary>
        public int duration;
        /// <summary>
        /// 此段路骑行方向
        /// </summary>
        public string orientation;
        /// <summary>
        /// 此段路骑行的坐标点，格式：X,Y;X1,Y1;X2,Y2
        /// </summary>
        public string polyline;
        /// <summary>
        /// 此段路骑行主要动作
        /// </summary>
        public string action;
        /// <summary>
        /// 此段路骑行辅助动作
        /// </summary>
        public string assistant_action;
    }
}
