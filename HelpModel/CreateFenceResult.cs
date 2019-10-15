using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.HelpModel
{
    /// <summary>
    /// 创建围栏结果
    /// </summary>
    public class CreateFenceResult
    {
        /// <summary>
        /// 围栏全局id
        /// <para>地理围栏实体的全局id</para>
        /// </summary>
        public string gid;
        /// <summary>
        /// 围栏id为预留字段，暂未使用，固定返回0
        /// </summary>
        public int id;
        /// <summary>
        /// 状态说明信息
        /// </summary>
        public string message;
        /// <summary>
        /// 状态值
        /// </summary>
        public string status;
    }

    /// <summary>
    /// 更新围栏结果
    /// </summary>
    public class UpdateFenceResult
    {
        /// <summary>
        /// 状态说明信息
        /// </summary>
        public string message;
        /// <summary>
        /// 状态值
        /// </summary>
        public string status;
    }


    /// <summary>
    /// 地理围栏查询结果
    /// </summary>
    public class FenceQueryResult
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        public int page_no;
        /// <summary>
        /// 每页数量
        /// </summary>
        public int page_size;
        /// <summary>
        /// 总记录数
        /// </summary>
        public int total_record;
    }

    /// <summary>
    /// 围栏查询到的具体单个围栏信息
    /// </summary>
    public class FenceResultObj : GeoFenceInfo
    {
        /// <summary>
        /// 围栏所在地区adcode
        /// </summary>
        public string adcode;
        /// <summary>
        /// 围栏创建时间
        /// </summary>
        public DateTime create_time;
        /// <summary>
        /// 围栏全局id
        /// </summary>
        public string gid;
        /// <summary>
        /// 围栏id
        /// </summary>
        public int id;
        /// <summary>
        /// 开发者key
        /// </summary>
        public string key;
    }

    public class FenceMonitorResult
    {
        /// <summary>
        /// 返回状态码 
        /// </summary>
        public string status;
        /// <summary>
        /// 围栏距离设备的距离，没有命中围栏时返回。单位：米
        /// <para>当设备不在围栏中时，会告知最近的围栏以及用户与这个围栏的距离，距离没有限制。</para>
        /// </summary>
        public int nearest_fence_distance;
        /// <summary>
        /// 最近的围栏id
        /// </summary>
        public string nearest_fence_gid;
        /// <summary>
        /// 围栏事件列表
        /// </summary>
        public List<FenceEventInfo> fencing_event_list;
    }

    /// <summary>
    /// 围栏事件信息
    /// </summary>
    public class FenceEventInfo
    {
        /// <summary>
        /// 设备行为。对应3种与围栏的动态交互关系，进/出/停留： enter|leave|stay
        /// </summary>
        public string client_action;
        /// <summary>
        /// 设备状态。当前与围栏的静态关系状态。是否在围栏里： in|out
        /// </summary>
        public string client_status;
        /// <summary>
        /// 用户进入围栏时间
        /// </summary>
        public DateTime enter_time;
        /// <summary>
        /// 围栏信息
        /// </summary>
        public Fence_Info fence_info;
    }

    /// <summary>
    /// 围栏信息
    /// </summary>
    public class Fence_Info
    {
        /// <summary>
        /// 全局围栏id
        /// </summary>
        public string fence_gid;
        /// <summary>
        /// 围栏名称
        /// </summary>
        public string fence_name;
    }
}
