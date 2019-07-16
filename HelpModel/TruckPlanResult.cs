using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.HelpModel
{
    /// <summary>
    /// 货车路径规划响应结果
    /// </summary>
    public class TruckPlanResult
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
        /// 返回状态说明，OK代表成功，否则返回错误原因
        /// </summary>
        public string errmsg;
        /// <summary>
        /// 货车路径规划具体内容
        /// </summary>
        public TruckData data;
    }

    /// <summary>
    /// 货车路径规划具体数据
    /// </summary>
    public class TruckData
    {
        /// <summary>
        /// 总共返回路线数
        /// </summary>
        public int count;
        /// <summary>
        /// 方案列表信息
        /// </summary>
        public TruckRouteInfo route;
    }

    /// <summary>
    /// 货车距离路线方案信息
    /// </summary>
    public class TruckRouteInfo
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
        /// 货车具体方案
        /// </summary>
        public List<TruckPathInfo> paths;
    }

    /// <summary>
    /// 货车具体方案
    /// </summary>
    public class TruckPathInfo
    {
        /// <summary>
        /// 此方案的行驶距离，单位：米
        /// </summary>
        public int distance;
        /// <summary>
        /// 此方案的耗时，单位：秒
        /// </summary>
        public int duration;
        /// <summary>
        /// 导航策略
        /// </summary>
        public string strategy;
        /// <summary>
        /// 此导航方案道路收费金额，单位：元
        /// </summary>
        public decimal tolls;
        /// <summary>
        /// 此导航方案道路收费距离长度，单位：米
        /// </summary>
        public int toll_distance;
        /// <summary>
        /// 限行结果，值与GaoDeConst.truckRestriction对应
        /// <para>0=未知（未输入完整/正确车牌号信息时候显示）1=已规避限行 2=起点限行 3=途径点在限行区域内（设置途径点才出现此报错） 4=途径限行区域 5=终点限行</para>
        /// </summary>
        public int restriction;
        /// <summary>
        /// 此方案红绿灯总数，单位：个
        /// </summary>
        public int traffic_lights;
        /// <summary>
        /// 货车导航路段集合
        /// </summary>
        public List<TruckStepInfo> steps;
        /// <summary>
        /// 限行结果中文
        /// </summary>
        public string Restriction
        {
            get
            {
                return GaoDeConst.truckRestriction[restriction];
            }
        }
    }

    /// <summary>
    /// 货车导航路段
    /// </summary>
    public class TruckStepInfo: DrivingStepInfo
    {
        /// <summary>
        /// 此路段预计时间，单位：秒
        /// </summary>
        public int duration;
    }
}
