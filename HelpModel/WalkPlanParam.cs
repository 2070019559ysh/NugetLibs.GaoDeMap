using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.HelpModel
{
    /// <summary>
    /// 步行路径规划请求参数
    /// </summary>
    public class WalkPlanParam : GaoDeBaseParam
    {
        /// <summary>
        /// 出发点，必填
        /// <para>规则：lon，lat（经度，纬度）， “,”分割，如117.500244, 40.417801 经纬度小数点不超过6位</para>
        /// </summary>
        public string origin;
        /// <summary>
        /// 目的地，必填
        /// <para>规则：lon，lat（经度，纬度）， “,”分割，如117.500244, 40.417801 经纬度小数点不超过6位</para>
        /// </summary>
        public string destination;
    }
}
