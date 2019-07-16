using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.HelpModel
{
    /// <summary>
    /// 行政区域查询参数
    /// </summary>
    public class AdminRegionQueryParam : GaoDeBaseParam
    {
        /// <summary>
        /// 查询关键字，必填
        /// <para>只支持单个关键词语搜索关键词支持：行政区名称、citycode、adcode</para>
        /// </summary>
        public string keywords;
        /// <summary>
        /// 子级行政区，可选
        /// <para>设置显示下级行政区级数（行政区级别包括：国家、省/直辖市、市、区/县、乡镇/街道多级数据）
        /// 0：不返回下级行政区；
        /// 1：返回下一级行政区；
        /// 2：返回下两级行政区；
        /// 3：返回下三级行政区
        /// </para>
        /// </summary>
        public int subdistrict = 1;
        /// <summary>
        /// 需要第几页数据，可选
        /// <para>最外层的districts最多会返回20个数据，若超过限制，请用page请求下一页数据。</para>
        /// </summary>
        public int page = 1;
        /// <summary>
        /// 最外层返回数据个数，可选
        /// </summary>
        public int offset = 20;
        /// <summary>
        /// 返回结果控制，可选
        /// <para>base:不返回行政区边界坐标点；
        /// all:只返回当前查询district的边界值，不返回子节点的边界值</para>
        /// </summary>
        public string extensions;
        /// <summary>
        /// 根据区划过滤，可选
        /// <para>按照指定行政区划进行过滤，填入后则只返回该省/直辖市信息
        /// 需填入adcode，为了保证数据的正确，强烈建议填入此参数</para>
        /// </summary>
        public string filter;
    }
}
