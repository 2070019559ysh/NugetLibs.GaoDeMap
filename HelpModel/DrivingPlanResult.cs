using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.HelpModel
{
    /// <summary>
    /// 驾车路径规划响应结果
    /// </summary>
    public class DrivingPlanResult : GaoDeBaseResult
    {
        /// <summary>
        /// 驾车路径规划方案数目
        /// </summary>
        public int count;
        /// <summary>
        /// 驾车路径规划信息
        /// </summary>
        public DrivingRouteInfo route;
    }

    /// <summary>
    /// 驾车路径规划信息
    /// </summary>
    public class DrivingRouteInfo
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
        /// 出租车费用，单位：元
        /// </summary>
        public decimal taxi_cost;
        /// <summary>
        /// 驾车换乘方案
        /// </summary>
        public List<DrivingPathInfo> paths;


    }

    /// <summary>
    /// 驾车路径方案信息
    /// </summary>
    public class DrivingPathInfo
    {
        /// <summary>
        /// 行驶距离，单位：米
        /// </summary>
        public int distance;
        /// <summary>
        /// 预计行驶时间，单位：秒
        /// </summary>
        public int duration;
        /// <summary>
        /// 导航策略
        /// </summary>
        public string strategy;
        /// <summary>
        /// 此导航方案道路收费，单位：元
        /// </summary>
        public decimal tolls;
        /// <summary>
        /// 限行结果
        /// <para>0 代表限行已规避或未限行，即该路线没有限行路段；1 代表限行无法规避，即该线路有限行路段</para>
        /// </summary>
        public int restriction;
        /// <summary>
        /// 红绿灯个数
        /// </summary>
        public int traffic_lights;
        /// <summary>
        /// 收费路段距离
        /// </summary>
        public int toll_distance;
        /// <summary>
        /// 驾车导航路段集合
        /// </summary>
        public List<DrivingStepInfo> steps;
    }

    /// <summary>
    /// 驾车导航路段
    /// </summary>
    public class DrivingStepInfo
    {
        /// <summary>
        /// 行驶指示
        /// </summary>
        public string instruction;
        /// <summary>
        /// 方向
        /// </summary>
        public string orientation;
        /// <summary>
        /// 道路名称
        /// </summary>
        public string road;
        /// <summary>
        /// 此路段距离，单位：米
        /// </summary>
        public int distance;
        /// <summary>
        /// 此段收费，单位：元
        /// </summary>
        public decimal tolls;
        /// <summary>
        /// 收费路段距离，单位：米
        /// </summary>
        public int toll_distance;
        /// <summary>
        /// 主要收费道路
        /// </summary>
        public string toll_road;
        /// <summary>
        /// 此路段坐标点串
        /// <para>格式为坐标串，如：116.481247,39.990704;116.481270,39.990726</para>
        /// </summary>
        public string polyline;
        /// <summary>
        /// 导航主要动作
        /// </summary>
        public string action;
        /// <summary>
        /// 导航辅助动作
        /// </summary>
        public string assistant_action;
        /// <summary>
        /// 驾车导航详细信息
        /// </summary>
        public List<DrivingTMC> tmcs;
        /// <summary>
        /// 驾车导航路段城市
        /// </summary>
        public List<DrivingCityCode> cities;
    }

    /// <summary>
    /// 驾车导航详细信息
    /// </summary>
    public class DrivingTMC
    {
        /// <summary>
        /// 行驶距离，单位：米
        /// </summary>
        public int distance;
        /// <summary>
        /// 此段路的交通情况
        /// <para>未知、畅通、缓行、拥堵、严重拥堵</para>
        /// </summary>
        public string status;
        /// <summary>
        /// 此段路的轨迹
        /// <para>规格：x1,y1;x2,y2</para>
        /// </summary>
        public string polyline;
    }

    /// <summary>
    /// 驾车导航路段城市信息
    /// </summary>
    public class DrivingCityCode : CityCodeInfo
    {
        /// <summary>
        /// 多个区域代号
        /// </summary>
        public List<DistrictCodeInfo> districts;
    }

    /// <summary>
    /// 城市代号信息
    /// </summary>
    public class CityCodeInfo
    {
        /// <summary>
        /// 城市名称
        /// </summary>
        public string name;
        /// <summary>
        /// 城市代号
        /// </summary>
        public string citycode;
        /// <summary>
        /// 区域代号
        /// </summary>
        public string adcode;
    }

    /// <summary>
    /// 区域代号信息
    /// </summary>
    public class DistrictCodeInfo
    {
        /// <summary>
        /// 区域名称
        /// </summary>
        public string name;
        /// <summary>
        /// 区域代号
        /// </summary>
        public string adcode;
    }
}
