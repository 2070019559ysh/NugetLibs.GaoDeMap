﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.HelpModel
{
    /// <summary>
    /// 高德常量汇总类
    /// </summary>
    public static class GaoDeConst
    {
        /// <summary>
        /// WebAPI接口的请求主机地址
        /// </summary>
        public const string WebAPIHost = "https://restapi.amap.com";

        /// <summary>
        /// 步行特殊的方式
        /// </summary>
        public static readonly Dictionary<int, string> walkType = new Dictionary<int, string>()
        {
            { 0,"普通道路" },
            { 1,"人行横道" },
            { 3,"地下通道" },
            { 4,"过街天桥" },
            { 5,"地铁通道" },
            { 6,"公园" },
            { 7,"广场" },
            { 8,"扶梯" },
            { 9,"直梯" },
            { 10,"索道" },
            { 11,"空中通道" },
            { 12,"建筑物穿越通道" },
            { 13,"行人通道" },
            { 14,"游船路线" },
            { 15,"观光车路线" },
            { 16,"滑道" },
            { 18,"扩路" },
            { 19,"道路附属连接线"},
            { 20,"阶梯" },
            { 21,"斜坡" },
            { 22,"桥" },
            { 23,"隧道" },
            { 30,"轮渡" }
        };
        /// <summary>
        /// 公交换乘策略
        /// </summary>
        public static readonly Dictionary<int, string> transitStrategy = new Dictionary<int, string>
        {
            { 0,"最快捷模式" },
            { 1,"最经济模式" },
            { 2,"最少换乘模式" },
            { 3,"最少步行模式" },
            { 5,"不乘地铁模式" }
        };
        /// <summary>
        /// 公交换乘火车路线类型
        /// </summary>
        public static readonly Dictionary<int, string> trainType = new Dictionary<int, string>
        {
            { 2010,"普客火车" },
            { 2011,"G字头的高铁火车" },
            { 2012,"D字头的动车火车" },
            { 2013,"C字头的城际火车" },
            { 2014,"Z字头的直达特快火车" },
            { 2015,"T字头的特快火车" },
            { 2016,"K字头的快车火车" },
            { 2017,"L字头，Y字头的临时火车" },
            { 2018,"S字头的郊区线火车" }
        };
        /// <summary>
        /// 公交换乘仓位级别
        /// </summary>
        public static readonly Dictionary<int, string> transitSpace = new Dictionary<int, string>
        {
            { 0,"不分仓位级别" },
            { 9,"特等座" },
            { 10,"火车硬座" },
            { 11,"火车软座" },
            { 12,"火车软座1等座" },
            { 13,"火车软座2等座" },
            { 14,"火车硬卧上铺" },
            { 15,"火车硬卧中铺" },
            { 16,"火车硬卧下铺" },
            { 17,"火车软卧上铺" },
            { 18,"火车软卧下铺" },
            { 19,"火车高级软卧上铺" },
            { 20,"火车高级软卧下铺" },
            { 21,"火车商务座" },
            { 22,"长途汽车座席" },
            { 23,"长途汽车卧席上铺" },
            { 24,"长途汽车卧席中铺" },
            { 25,"长途汽车卧席下铺" },
            { 30,"飞机经济舱" },
            { 31,"飞机商务舱" },
            { 40,"客轮经济舱"},
            { 41,"客轮3等舱" },
            { 42,"客轮2等舱" },
            { 43,"客轮豪华舱" }
        };
        /// <summary>
        /// 驾车选择策略
        /// </summary>
        public static readonly Dictionary<int, string> drivingStrategy = new Dictionary<int, string>()
        {
            //下方策略仅返回一条路径规划结果
            { 0,"速度优先，不考虑当时路况，此路线不一定距离最短" },
            { 1,"费用优先，不走收费路段，且耗时最少的路线" },
            { 2,"距离优先，不考虑路况，仅走距离最短的路线，但是可能存在穿越小路/小区的情况" },
            { 3,"速度优先，不走快速路，例如京通快速路（因为策略迭代，建议使用13）" },
            { 4,"躲避拥堵，但是可能会存在绕路的情况，耗时可能较长" },
            { 5,"多策略（同时使用速度优先、费用优先、距离优先三个策略计算路径）" },
            { 6,"速度优先，不走高速，但是不排除走其余收费路段" },
            { 7,"费用优先，不走高速且避免所有收费路段" },
            { 8,"躲避拥堵和收费，可能存在走高速的情况，并且考虑路况不走拥堵路线，但有可能存在绕路和时间较长" },
            { 9,"躲避拥堵和收费，不走高速" },
            //下方策略返回多条路径规划结果
            { 10,"返回结果会躲避拥堵，路程较短，尽量缩短时间，与高德地图的默认策略也就是不进行任何勾选一致" },
            { 11,"返回三个结果包含：时间最短；距离最短；躲避拥堵 （由于有更优秀的算法，建议用10代替）" },
            { 12,"返回的结果考虑路况，尽量躲避拥堵而规划路径，与高德地图的“躲避拥堵”策略一致" },
            { 13,"返回的结果不走高速，与高德地图“不走高速”策略一致" },
            { 14,"返回的结果尽可能规划收费较低甚至免费的路径，与高德地图“避免收费”策略一致" },
            { 15,"返回的结果考虑路况，尽量躲避拥堵而规划路径，并且不走高速，与高德地图的“躲避拥堵&不走高速”策略一致" },
            { 16,"返回的结果尽量不走高速，并且尽量规划收费较低甚至免费的路径结果，与高德地图的“避免收费&不走高速”策略一致" },
            { 17,"返回路径规划结果会尽量的躲避拥堵，并且规划收费较低甚至免费的路径结果，与高德地图的“躲避拥堵&避免收费”策略一致" },
            { 18,"返回的结果尽量躲避拥堵，规划收费较低甚至免费的路径结果，并且尽量不走高速路，与高德地图的“避免拥堵&避免收费&不走高速”策略一致" },
            { 19,"返回的结果会优先选择高速路，与高德地图的“高速优先”策略一致" },
            { 20,"返回的结果会优先考虑高速路，并且会考虑路况躲避拥堵，与高德地图的“躲避拥堵&高速优先”策略一致" }
        };
        /// <summary>
        /// 货车选择策略
        /// </summary>
        public static readonly Dictionary<int, string> truckStrategy = new Dictionary<int, string>()
        {
            { 1,"返回的结果考虑路况，尽量躲避拥堵而规划路径，与高德地图的“躲避拥堵”策略一致" },
            { 2,"返回的结果不走高速，与高德地图“不走高速”策略一致" },
            { 3,"返回的结果尽可能规划收费较低甚至免费的路径，与高德地图“避免收费”策略一致" },
            { 4,"返回的结果考虑路况，尽量躲避拥堵而规划路径，并且不走高速，与高德地图的“躲避拥堵&不走高速”策略一致" },
            { 5,"返回的结果尽量不走高速，并且尽量规划收费较低甚至免费的路径结果，与高德地图的“避免收费&不走高速”策略一致" },
            { 6,"返回路径规划结果会尽量的躲避拥堵，并且规划收费较低甚至免费的路径结果，与高德地图的“躲避拥堵&避免收费”策略一致" },
            { 7,"返回的结果尽量躲避拥堵，规划收费较低甚至免费的路径结果，并且尽量不走高速路，与高德地图的“避免拥堵&避免收费&不走高速”策略一致" },
            { 8,"返回的结果会优先选择高速路，与高德地图的“高速优先”策略一致" },
            { 9,"返回的结果会优先考虑高速路，并且会考虑路况躲避拥堵，与高德地图的“躲避拥堵&高速优先”策略一致" },
            { 10,"不考虑路况，返回速度优先的路线，此路线不一定距离最短" }
        };
        /// <summary>
        /// 车辆类型
        /// </summary>
        public static readonly Dictionary<int, string> carType = new Dictionary<int, string>()
        {
            { 0,"普通汽车" },
            { 1,"纯电动车" },
            { 2,"插电混动车" }
        };
        /// <summary>
        /// 货车大小类型
        /// </summary>
        public static readonly Dictionary<int, string> truckSize = new Dictionary<int, string>()
        {
            {1,"微型车" },{2,"轻型车" },{3,"中型车" },{4,"重型车" }
        };
        /// <summary>
        /// 路径计算的方式
        /// </summary>
        public static readonly Dictionary<int, string> pathMeasureType = new Dictionary<int, string>()
        {
            { 0,"直线距离" },
            { 1,"驾车导航距离（仅支持国内坐标）" },
            { 2,"公交规划距离（仅支持同城坐标）" },
            {3,"步行规划距离（仅支持5km之间的距离）"}
        };
        /// <summary>
        /// 货车限行类型
        /// </summary>
        public static readonly Dictionary<int, string> truckRestriction = new Dictionary<int, string>()
        {
            { 0,"未知（未输入完整/正确车牌号信息时候显示）"},
            { 1,"已规避限行" },
            { 2,"起点限行" },
            { 3,"途径点在限行区域内（设置途径点才出现此报错）" },
            { 4,"途径限行区域" },
            { 5,"终点限行" }
        };
        /// <summary>
        /// 行政区域级别
        /// </summary>
        public static readonly Dictionary<string, string> districtLevel = new Dictionary<string, string>()
        {
            { "country","国家" },
            { "province","省份" },
            { "city","市" },
            { "district","区县" },
            { "street","街道" }
        };
    }
}
