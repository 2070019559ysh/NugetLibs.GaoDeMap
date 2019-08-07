using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.HelpModel
{
    /// <summary>
    /// 天气查询城市参数
    /// </summary>
    public class SkyCityParam : GaoDeBaseParam
    {
        /// <summary>
        /// 城市编码（城市的adcode），必填
        /// </summary>
        public string city;
        /// <summary>
        /// 气象类型，可选
        /// <para>可选值：base/all；base:返回实况天气；all:返回预报天气</para>
        /// </summary>
        public string extensions;
    }
}
