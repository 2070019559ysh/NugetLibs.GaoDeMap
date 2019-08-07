using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.HelpModel
{
    /// <summary>
    /// 输入提示请求参数
    /// </summary>
    public class InputTipsParam : GaoDeBaseParam
    {
        /// <summary>
        /// 查询关键字，必填
        /// </summary>
        public string keywords;
        /// <summary>
        /// POI分类，可选
        /// <para>支持传入多个分类，多个类型用“|”分隔</para>
        /// <para>可选值：POI分类名称、分类代码</para>
        /// <para>强烈建议使用分类代码，否则可能会得到不符合预期的结果</para>
        /// </summary>
        public string type;
        /// <summary>
        /// 坐标，可选
        /// <para>格式：经度,纬度，使用location则附近优先返回搜索关键词信息</para>
        /// </summary>
        public string location;
        /// <summary>
        /// 搜索城市，可选
        /// <para>可选值：城市名、citycode、adcode，不支持县级市</para>
        /// <para>填入此参数后，会尽量优先返回此城市数据，但是不一定仅局限此城市结果，若仅需要某个城市数据请调用citylimit参数</para>
        /// </summary>
        public string city;
        /// <summary>
        /// 仅返回指定城市数据，可选
        /// </summary>
        public bool citylimit;
        /// <summary>
        /// 返回的数据类型，可选
        /// <para>多种数据类型用“|”分隔，可选值：all-返回所有数据类型、poi-返回POI数据类型、bus-返回公交站点数据类型、busline-返回公交线路数据类型</para>
        /// </summary>
        public string datatype = "all";
    }
}
