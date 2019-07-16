using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.HelpModel
{
    /// <summary>
    /// 骑行路径规划请求参数
    /// </summary>
    public class BicyclingPlanParam : GaoDeBaseParam
    {
        /// <summary>
        /// 出发点经纬度，必填
        /// <para>经度在前，纬度在后，经纬度小数点后不得超过6位。格式为x,y</para>
        /// </summary>
        public string origin;
        /// <summary>
        /// 目的地经纬度，必填
        /// <para>经度在前，纬度在后，经度和纬度用","分割，经纬度小数点后不得超过6位。</para>
        /// </summary>
        public string destination;
    }
}
