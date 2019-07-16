using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.HelpModel
{
    /// <summary>
    /// 步行路径规划响应结果
    /// </summary>
    public class WalkPlanResult : GaoDeBaseResult
    {
        /// <summary>
        /// 返回结果数目
        /// </summary>
        public int count;
        /// <summary>
        /// 路线信息
        /// </summary>
        public WalkRouteInfo route;
    }

    /// <summary>
    /// 步行路线信息
    /// </summary>
    public class WalkRouteInfo
    {
        /// <summary>
        /// 起点坐标
        /// </summary>
        public string origin;
        /// <summary>
        /// 终点坐标
        /// </summary>
        public string destination;
        /// <summary>
        /// 步行方案
        /// </summary>
        public List<WalkPathInfo> paths;
    }

    /// <summary>
    /// 步行方案
    /// </summary>
    public class WalkPathInfo
    {
        /// <summary>
        /// 起点和终点的步行距离，单位：米
        /// </summary>
        public int distance;
        /// <summary>
        /// 步行时间预计，单位：秒
        /// </summary>
        public int duration;
        /// <summary>
        /// 步行结果列表
        /// </summary>
        public List<WalkStepInfo> steps;
    }

    /// <summary>
    /// 每段步行方案信息
    /// </summary>
    public class WalkStepInfo
    {
        /// <summary>
        /// 路段步行指示
        /// </summary>
        public string instruction;
        /// <summary>
        /// 道路名称
        /// </summary>
        public string road;
        /// <summary>
        /// 此路段距离，单位：米
        /// </summary>
        public int distance;
        /// <summary>
        /// 方向
        /// </summary>
        public string orientation;
        /// <summary>
        /// 此路段预计步行时间，单位：秒
        /// </summary>
        public string duration;
        /// <summary>
        /// 此路段坐标点
        /// </summary>
        public string polyline;
        /// <summary>
        /// 步行主要动作
        /// </summary>
        public string action;
        /// <summary>
        /// 步行辅助动作
        /// </summary>
        public string assistant_action;
        /// <summary>
        /// 这段路是否存在特殊的方式，与GaoDeConst.walkType对应
        /// </summary>
        public int walk_type;
        /// <summary>
        /// 这段路步行特殊的方式
        /// </summary>
        public string WalkTypeStr
        {
            get
            {
                return GaoDeConst.walkType[walk_type];
            }
        }
    }
}
