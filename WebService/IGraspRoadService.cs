using NugetLibs.GaoDeMap.HelpModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.WebService
{
    /// <summary>
    /// 轨迹纠偏数据处理服务接口声明
    /// </summary>
    public interface IGraspRoadService
    {
        /// <summary>
        /// 抓取道路驾驶轨迹信息
        /// <para>根据坐标点抓取道路，即根据给定的坐标点、车辆的方位角以及行驶速度，将用户的轨迹纠偏到路上，从而返回用户实际驾车经过的道路坐标</para>
        /// </summary>
        /// <param name="driveRoads">抓取到的驾驶坐标信息数组</param>
        /// <returns>道路驾驶轨迹信息结果</returns>
        GaoDeErrResult<DrivePointsResult> FetchDrivingInfo(DriveRoadInfo[] driveRoads);
    }
}
