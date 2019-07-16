using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.HelpModel
{
    /// <summary>
    /// 周边搜索POI查询参数
    /// </summary>
    public class POIAroundParam : GaoDeBaseParam
    {
        /// <summary>
        /// 中心点坐标，必填
        /// <para>规则：经度和纬度用","分割，经度在前，纬度在后，经纬度小数点后不得超过6位</para>
        /// </summary>
        public string location;
        /// <summary>
        /// 查询关键字，可选
        /// <para>多个关键字用“|”分割</para>
        /// </summary>
        public string keywords;
        /// <summary>
        /// 查询POI类型，可选
        /// <para>1、可选值：分类代码 或 汉字（若用汉字，请严格按POI分类编码和城市编码表的汉字填写）</para>
        /// <para>2、当您的keywords和types都是空时，默认指定types为050000（餐饮服务）、070000（生活服务）、120000（商务住宅）</para>
        /// </summary>
        public string types;
        /// <summary>
        /// 查询城市，可选
        /// <para>1、可选值：城市中文、中文全拼、citycode、adcode</para>
        /// <para>2、当用户指定的经纬度和city出现冲突，若范围内有用户指定city的数据，则返回相关数据，否则返回为空</para>
        /// <para>3、默认全国范围内搜索</para>
        /// </summary>
        public string city;
        /// <summary>
        /// 查询半径，可选
        /// <para>取值范围:0-50000。规则：大于50000按默认值3000，单位：米</para>
        /// </summary>
        public int radius;
        /// <summary>
        /// 排序规则，可选
        /// <para>规定返回结果的排序规则，按距离排序：distance；综合排序：weight。默认distance</para>
        /// </summary>
        public string sortrule;
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
