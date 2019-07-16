using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.HelpModel
{
    /// <summary>
    /// IP所在城市位置信息
    /// </summary>
    public class IPCityResult : GaoDeBaseResult
    {
        /// <summary>
        /// 省份名称
        /// <para>若为直辖市则显示直辖市名称；如果在局域网 IP网段内，则返回“局域网”；非法IP以及国外IP则返回空</para>
        /// </summary>
        public string province;
        /// <summary>
        /// 城市名称
        /// <para>若为直辖市则显示直辖市名称；如果为局域网网段内IP或者非法IP或国外IP，则返回空</para>
        /// </summary>
        public string city;
        /// <summary>
        /// 城市的adcode编码
        /// </summary>
        public string adcode;
        /// <summary>
        /// 所在城市矩形区域范围，所在城市范围的左下右上对标对，如：116.0119343,39.66127144;116.7829835,40.2164962
        /// </summary>
        public string rectangle;
    }
}
