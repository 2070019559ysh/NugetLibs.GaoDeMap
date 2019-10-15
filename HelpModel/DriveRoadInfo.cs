using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.HelpModel
{
    /// <summary>
    /// 驾驶道理轨迹信息
    /// </summary>
    public class DriveRoadInfo
    {
        /// <summary>
        /// 经度，小数点后最多6位，必填
        /// </summary>
        public string x;
        /// <summary>
        /// 纬度，小数点后最多6位，必填 
        /// </summary>
        public string y;
        /// <summary>
        /// 角度，与正北方向的夹角,小数、整数均可，必填
        /// <para>需要注意的是，计算时需要参考到设备的角度来判别方向，如果ag参数是0，或者是不合法的参数，会比较大概率导致纠偏计算失败</para>
        /// </summary>
        public float ag;
        /// <summary>
        /// 秒级时间，必填
        /// <para>第一个点对应的tm参数为unix时间戳，1970年到当前的秒数；从第二个点的tm参数开始，tm取值为相对于前一个tm的时间增量，起始时间戳和时间增量均不能为0，需要真实合理的时间</para>
        /// </summary>
        public long tm;
        /// <summary>
        /// 速度，车辆/设备的移动速度，必填
        /// <para>单位：km/h ,小数、整数均可，在计算纠偏时如果速度值不合理，会比较大概率导致纠偏计算失败。在使用时请传入合理的速度值</para>
        /// </summary>
        public float sp;
    }
}
