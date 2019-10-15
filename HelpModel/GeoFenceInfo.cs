using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.HelpModel
{
    /// <summary>
    /// 地理围栏信息
    /// </summary>
    public class GeoFenceInfo
    {
        /// <summary>
        /// 围栏名称，必填
        /// <para>字母|数字|汉字</para>
        /// </summary>
        public string name;
        /// <summary>
        /// 圆形围栏中心点
        /// <para>格式：经度,纬度，圆形围栏必填与points互斥</para>
        /// </summary>
        public string center;
        /// <summary>
        /// 圆形围栏半径，单位：米，[0,5000]
        /// <para>圆形围栏必填与points互斥</para>
        /// </summary>
        public int radius;
        /// <summary>
        /// 多边形围栏坐标点，多边形围栏必填
        /// <para>格式：经度,纬度，多个“;”分隔，数量3&lt;=点个数&lt;=5000</para>
        /// <para>多边形围栏外接圆半径最大为5000米</para>
        /// </summary>
        public string points;
        /// <summary>
        /// 围栏监控状态，可选
        /// </summary>
        public bool enable = true;
        /// <summary>
        /// 过期日期
        /// <para>围栏有效截止日期，过期后不对此围栏进行维护（围栏数据过期删除）</para>
        /// <para>不能设定创建围栏时间点之前的日期</para>
        /// <para>格式yyyy-MM-dd； 请设置2055年之前的日期</para>
        /// </summary>
        public string valid_time;
        /// <summary>
        /// 一周内围栏监控日期的重复模式，可选
        /// <para>星期缩写列表，用","或“;”隔开</para>
        /// <para>样例："Mon,Sat" 表示周一和周六有效</para>
        /// <para>星期简称如下（首字母大写）： Mon,Tues,Wed,Thur,Fri,Sat,Sun</para>
        /// <para>repeat和fixed_date不能同时缺省或同时为空，二者所指出的监控日期为“或”关系</para>
        /// </summary>
        public string repeat;
        /// <summary>
        /// 指定日期列表，可选
        /// <para>格式"date1;date2;date3"； date格式"yyyy-MM-dd"</para>
        /// <para>最大个数180，不能设定过去日期</para>
        /// <para>repeat和fixed_date不能同时缺省或同时为空，二者所指出的监控日期为“或”关系</para>
        /// </summary>
        public string fixed_date;
        /// <summary>
        /// 一天内围栏监控时段，可选
        /// <para>开始时间和结束时间定义一时间段，可设置多个时间段，时间段按照时间顺序排列，各时间段不可重叠</para>
        /// <para>拼接字符串格式如："startTime1,endTime1;startTime2,endTime2"</para>
        /// <para>最大个数24；不可为空；</para>
        /// <para>范围00:00-23:59；时间段不可重叠；时间段长度>15min</para>
        /// </summary>
        public string time;
        /// <summary>
        /// 围栏描述信息，可选
        /// </summary>
        public string desc;
        /// <summary>
        /// 配置触发围栏所需动作，可选
        /// <para>触发动作分号分割：enter;leave（进入、离开触发）</para>
        /// </summary>
        public string alert_condition;
    }

    /// <summary>
    /// 查询围栏参数
    /// </summary>
    public class FenceQueryParam : GaoDeBaseParam
    {
        /// <summary>
        /// 围栏id，可选
        /// </summary>
        public int id;
        /// <summary>
        /// 围栏全局id，可选
        /// </summary>
        public string gid;
        /// <summary>
        /// 围栏名称，可选
        /// </summary>
        public string name;
        /// <summary>
        /// 当前页码
        /// </summary>
        public int page_no = 1;
        /// <summary>
        /// 每页数量
        /// </summary>
        public int page_size = 20;
        /// <summary>
        /// 围栏激活状态
        /// </summary>
        public bool enable = true;
        /// <summary>
        /// 按创建时间查询的起始时间
        /// </summary>
        public DateTime start_time;
        /// <summary>
        /// 按创建时间查询的结束时间 
        /// </summary>
        public DateTime end_time;
    }

    /// <summary>
    /// 围栏设备监控参数
    /// </summary>
    public class FenceMonitorParam : GaoDeBaseParam
    {
        /// <summary>
        /// 用户设备唯一标识符
        /// </summary>
        public string diu;
        /// <summary>
        /// 设备在开发者系统中的id
        /// </summary>
        public string uid;
        /// <summary>
        /// 设备位置坐标组
        /// <para>坐标数据和坐标产生的时间戳数据，格式: x1,y1,unix_ts1;x2,y2,unix_ts2</para>
        /// <para>1、传入1个点时，直接判断交互关系。</para>
        /// <para>2、当传入多个点时，可以通过前后时间判断动态交互关系。</para>
        /// </summary>
        public string locations;
    }
}
