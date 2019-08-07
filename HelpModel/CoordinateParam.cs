using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.HelpModel
{
    /// <summary>
    /// 坐标请求参数
    /// </summary>
    public class CoordinateParam : GaoDeBaseParam
    {
        /// <summary>
        /// 待转换的坐标点，最多支持40对坐标，必填
        /// <para>经度和纬度用","分割，经度在前，纬度在后，经纬度小数点后不得超过6位，多个坐标之间用“|”分隔</para>
        /// </summary>
        public string locations;
        /// <summary>
        /// 原坐标系，可选
        /// </summary>
        public CoordsysType coordsys = CoordsysType.autonavi;
    }

    /// <summary>
    /// 坐标转换的响应结果
    /// </summary>
    public class CoordinateResult : GaoDeBaseResult
    {
        /// <summary>
        /// 转换之后的坐标。若有多个坐标，则用 “;”进行区分和间隔
        /// </summary>
        public string locations;
    }

    /// <summary>
    /// 地图坐标系
    /// </summary>
    public enum CoordsysType
    {
        /// <summary>
        /// GPS的坐标
        /// </summary>
        gps,
        /// <summary>
        /// mapbar坐标
        /// </summary>
        mapbar,
        /// <summary>
        /// 百度地图坐标
        /// </summary>
        baidu,
        /// <summary>
        /// 不进行转换
        /// </summary>
        autonavi
    }
}
