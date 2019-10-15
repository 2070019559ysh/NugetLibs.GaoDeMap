using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.HelpModel
{
    /// <summary>
    /// 架设道路轨迹坐标点结果
    /// </summary>
    public class DrivePointsResult
    {
        /// <summary>
        /// 总距离
        /// </summary>
        public int distance;
        /// <summary>
        /// 返回坐标合集
        /// </summary>
        public PointInfo[] points;
    }

    public class PointInfo
    {
        /// <summary>
        /// 经度
        /// </summary>
        public string x;
        /// <summary>
        /// 纬度
        /// </summary>
        public string y;
    }
}
