using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.HelpModel
{
    /// <summary>
    /// 关键字搜索POI查询参数
    /// </summary>
    public class POITextParam : GaoDeBaseParam
    {
        /// <summary>
        /// 查询关键字，必填(keywords和types两者至少必选其一)
        /// <para>多个关键字用“|”分割，若不指定city，并且搜索的为泛词（例如“美食”）的情况下，返回的内容为城市列表以及此城市内有多少结果符合要求</para>
        /// </summary>
        public string keywords;
        /// <summary>
        /// 查询POI类型，必填(keywords和types两者至少必选其一)
        /// <para>1、可选值：分类代码 或 汉字（若用汉字，请严格按POI分类编码和城市编码表的汉字填写）</para>
        /// <para>2、若不指定city，返回的内容为城市列表以及此城市内有多少结果符合要求</para>
        /// <para>3、当您的keywords和types都是空时，默认指定types为120000（商务住宅）150000（交通设施服务）</para>
        /// </summary>
        public string types;
        /// <summary>
        /// 查询城市，可选
        /// <para>1、可选值：城市中文、中文全拼、citycode、adcode</para>
        /// <para>2、填入此参数后，会尽量优先返回此城市数据，但是不一定仅局限此城市结果，若仅需要某个城市数据请调用citylimit参数。如不同城市有同名地点</para>
        /// </summary>
        public string city;
        /// <summary>
        /// 仅返回指定城市数据，可选
        /// </summary>
        public bool citylimit;
        /// <summary>
        /// 是否按照层级展示子POI数据，可选
        /// <para>可选值：当为0的时候，子POI都会显示。当为1的时候，子POI会归类到父POI之中。仅在extensions=all的时候生效</para>
        /// </summary>
        public int children = 0;
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
