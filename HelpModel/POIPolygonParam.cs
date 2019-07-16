using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.HelpModel
{
    /// <summary>
    /// 多边形搜索POI查询参数
    /// </summary>
    public class POIPolygonParam : GaoDeBaseParam
    {
        /// <summary>
        /// 经纬度坐标对，必填
        /// <para>规则：经度和纬度用","分割，经度在前，纬度在后，坐标对用"|"分割。经纬度小数点后不得超过6位</para>
        /// <para>多边形为矩形时，可传入左上右下两顶点坐标对；其他情况下首尾坐标对需相同。</para>
        /// </summary>
        public string polygon;
        /// <summary>
        /// 查询关键字，可选
        /// <para>多个关键字用“|”分割</para>
        /// </summary>
        public string keywords;
        /// <summary>
        /// 查询POI类型，可选
        /// <para>1、可选值：分类代码 或 汉字（若用汉字，请严格按POI分类编码和城市编码表的汉字填写）</para>
        /// <para>2、当您的keywords和types都是空时，默认指定types为为120000（商务住宅）&150000（交通设施服务）</para>
        /// </summary>
        public string types;
        /// <summary>
        /// 每页记录数据，可选
        /// <para>强烈建议不超过25，若超过25可能造成访问报错。默认10</para>
        /// </summary>
        public int offset = 10;
        /// <summary>
        /// 当前页数，可选
        /// <para>最大翻页数100，默认1</para>
        /// </summary>
        public int page = 1;
        /// <summary>
        /// 返回结果控制，可选
        /// <para>base:默认返回基本地址信息；all:返回地址信息、附近POI、道路以及道路交叉口信息</para>
        /// </summary>
        public string extensions;
    }
}
