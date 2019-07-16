using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.HelpModel
{
    /// <summary>
    /// 距离测量请求参数
    /// </summary>
    public class DistanceParam : GaoDeBaseParam
    {
        /// <summary>
        /// 出发点，必填
        /// <para>公交支持20个坐标对，其余支持100个坐标对，坐标对见用“| ”分隔；经度和纬度用","分隔</para>
        /// </summary>
        public string origins;
        /// <summary>
        /// 目的地，必填
        /// <para>格式为x,y，经纬度小数点不超过6位</para>
        /// </summary>
        public string destination;
        /// <summary>
        /// 路径计算的方式和方法，值与GaoDeConst.pathMeasureType对应
        /// </summary>
        public int type;
    }
}
