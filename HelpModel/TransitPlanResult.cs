using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.HelpModel
{
    /// <summary>
    /// 公交路径规划响应结果
    /// </summary>
    public class TransitPlanResult : GaoDeBaseResult
    {
        /// <summary>
        /// 返回公交换乘方案数目
        /// </summary>
        public int count;
        /// <summary>
        /// 公交换乘信息
        /// </summary>
        public TransitRouteInfo route;
    }

    /// <summary>
    /// 公交换乘路线信息
    /// </summary>
    public class TransitRouteInfo
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
        /// 起点和终点的步行距离，单位：米
        /// </summary>
        public int distance;
        /// <summary>
        /// 出租车费用，单位：元
        /// </summary>
        public decimal taxi_cost;
        /// <summary>
        /// 公交换乘方案列表
        /// </summary>
        public List<TransitTransfer> transits;
    }

    /// <summary>
    /// 公交换乘具体内容
    /// </summary>
    public class TransitTransfer
    {
        /// <summary>
        /// 此换乘方案价格，单位：元
        /// </summary>
        public decimal cost;
        /// <summary>
        /// 此换乘方案预期时间，单位：秒
        /// </summary>
        public int duration;
        /// <summary>
        /// 是否是夜班车，0：非夜班车；1：夜班车
        /// </summary>
        public string nightflag;
        /// <summary>
        /// 此方案总步行距离，单位：米
        /// </summary>
        public string walking_distance;
        /// <summary>
        /// 换乘路段列表
        /// </summary>
        public List<SegmentInfo> segments;
    }

    /// <summary>
    /// 每段路的规划信息
    /// </summary>
    public class SegmentInfo
    {
        /// <summary>
        /// 路段的步行导航信息
        /// </summary>
        public TransitWalkInfo walking;
        /// <summary>
        /// 此路段公交导航信息
        /// </summary>
        public TransitBusInfo bus;
        /// <summary>
        /// 地铁入口，只在地铁路段有值可转为SubwayDoorInfo类型
        /// </summary>
        public SubwayDoorInfo entrance;
        /// <summary>
        /// 地铁出口，只在地铁路段有值可转为SubwayDoorInfo类型
        /// </summary>
        public SubwayDoorInfo exit;
        /// <summary>
        /// 乘坐火车的信息，只在地铁路段有值
        /// </summary>
        public TransitTrainInfo railway;
    }

    /// <summary>
    /// 公交换乘中的步行方案信息
    /// </summary>
    public class TransitWalkInfo
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
    /// 公交站点信息
    /// </summary>
    public class BusStopInfo
    {
        /// <summary>
        /// 站点名字
        /// </summary>
        public string name;
        /// <summary>
        /// 站点id
        /// </summary>
        public string id;
        /// <summary>
        /// 站点经纬度
        /// </summary>
        public string location;
    }

    /// <summary>
    /// 公交换乘中的公交方案信息
    /// </summary>
    public class TransitBusInfo
    {
        /// <summary>
        /// 公交线路信息列表
        /// </summary>
        public List<TransitBusLine> buslines;
    }

    /// <summary>
    /// 公交线路信息
    /// </summary>
    public class TransitBusLine
    {
        /// <summary>
        /// 此段起乘站信息
        /// </summary>
        public BusStopInfo departure_stop;
        /// <summary>
        /// 此段下车站
        /// </summary>
        public BusStopInfo arrival_stop;
        /// <summary>
        /// 公交路线名称，格式如：445路(南十里居--地铁望京西站)
        /// </summary>
        public string name;
        /// <summary>
        /// 公交路线id
        /// </summary>
        public string id;
        /// <summary>
        /// 公交类型，格式如：地铁线路
        /// </summary>
        public string type;
        /// <summary>
        /// 公交行驶距离，单位：米
        /// </summary>
        public int distance;
        /// <summary>
        /// 公交预计行驶时间，单位：秒
        /// </summary>
        public int duration;
        /// <summary>
        /// 此路段坐标集，格式为坐标串，如：116.481247,39.990704;116.481270,39.990726
        /// </summary>
        public string polyline;
        /// <summary>
        /// 首班车时间，格式如：0600，代表06:00
        /// </summary>
        public object start_time;
        /// <summary>
        /// 末班车时间，格式如：2300，代表23：00
        /// </summary>
        public object end_time;
        /// <summary>
        /// 此段途经公交站数
        /// </summary>
        public int via_num;
        /// <summary>
        /// 此段途经公交站点列表
        /// </summary>
        public List<BusStopInfo> via_stops;
    }

    /// <summary>
    /// 地铁出入口信息
    /// </summary>
    public class SubwayDoorInfo
    {
        /// <summary>
        /// 出入口名字
        /// </summary>
        public string name;
        /// <summary>
        /// 出入口经纬度
        /// </summary>
        public string location;
    }

    /// <summary>
    /// 公交换乘中的火车方案信息
    /// </summary>
    public class TransitTrainInfo
    {
        /// <summary>
        /// 线路id编号
        /// </summary>
        public string id;
        /// <summary>
        /// 该线路车段耗时，单位：秒
        /// </summary>
        public int time;
        /// <summary>
        /// 线路名称
        /// </summary>
        public string name;
        /// <summary>
        /// 线路车次号
        /// </summary>
        public string trip;
        /// <summary>
        /// 该换乘段的行车总距离，单位：米
        /// </summary>
        public int distance;
        /// <summary>
        /// 线路车次类型，值与GaoDeConst.trainType对应
        /// </summary>
        public string type;
        /// <summary>
        /// 火车始发站信息
        /// </summary>
        public StartTrainStation departure_stop;
        /// <summary>
        /// 火车到站信息
        /// </summary>
        public EndTrainStation arrival_stop;
        /// <summary>
        /// 途径站点信息，extensions=all时返回
        /// </summary>
        public ViaTrainStation via_stop;
        /// <summary>
        /// 聚合的备选方案，extensions=all时返回
        /// </summary>
        public List<TrainAlterInfo> alters;
        /// <summary>
        /// 仓位及价格信息，有值时可转TransitSpaceInfo类型
        /// </summary>
        public List<TransitSpaceInfo> spaces;
    }

    /// <summary>
    /// 火车始发站信息
    /// </summary>
    public class StartTrainStation
    {
        /// <summary>
        /// 上车站点ID
        /// </summary>
        public string id;
        /// <summary>
        /// 上车站点名称
        /// </summary>
        public string name;
        /// <summary>
        /// 上车站点经纬度
        /// </summary>
        public string location;
        /// <summary>
        /// 上车站点所在城市的adcode
        /// </summary>
        public string adcode;
        /// <summary>
        /// 上车点发车时间，格式如：0630代表06:30
        /// </summary>
        public string time;
        /// <summary>
        /// 是否始发站，1表示为始发站，0表示非始发站
        /// </summary>
        public string start;
    }

    /// <summary>
    /// 火车到站信息
    /// </summary>
    public class EndTrainStation
    {
        /// <summary>
        /// 下车站点ID
        /// </summary>
        public string id;
        /// <summary>
        /// 下车站点名称
        /// </summary>
        public string name;
        /// <summary>
        /// 下车站点经纬度
        /// </summary>
        public string location;
        /// <summary>
        /// 下车站点所在城市的adcode
        /// </summary>
        public string adcode;
        /// <summary>
        /// 下车点发车时间，格式如：0630代表06:30，如大于24:00,则表示跨天
        /// </summary>
        public string time;
        /// <summary>
        /// 是否为终点站，1表示为终点站，0表示非终点站
        /// </summary>
        public string end;
    }

    /// <summary>
    /// 途径站点信息
    /// </summary>
    public class ViaTrainStation
    {
        /// <summary>
        /// 途径站点的ID
        /// </summary>
        public string id;
        /// <summary>
        /// 途径站点的名称
        /// </summary>
        public string name;
        /// <summary>
        /// 途径站点的坐标点
        /// </summary>
        public string location;
        /// <summary>
        /// 途径站点的进站时间，如大于24:00,则表示跨天
        /// </summary>
        public string time;
        /// <summary>
        /// 途径站点的停靠时间，单位：分钟
        /// </summary>
        public int wait;
    }

    /// <summary>
    /// 聚合的备选方案
    /// </summary>
    public class TrainAlterInfo
    {
        /// <summary>
        /// 备选方案ID
        /// </summary>
        public string id;
        /// <summary>
        /// 备选线路名称
        /// </summary>
        public string name;
    }

    /// <summary>
    /// 仓位及价格信息
    /// </summary>
    public class TransitSpaceInfo
    {
        /// <summary>
        /// 仓位编码，值与GaoDeConst.transitSpace对应
        /// </summary>
        public object code;
        /// <summary>
        /// 仓位费用，单位：元
        /// </summary>
        public decimal cost;
    }
}
