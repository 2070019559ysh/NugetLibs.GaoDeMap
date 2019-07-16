using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.HelpModel
{
    /// <summary>
    /// 行政区域查询的结果
    /// </summary>
    public class AdminRegionQueryResult : GaoDeBaseResult
    {
        /// <summary>
        /// 建议结果
        /// </summary>
        public SuggestionInfo suggestion;
        /// <summary>
        /// 行政区列表
        /// </summary>
        public List<DistrictInfo> districts;
    }

    /// <summary>
    /// 建议结果关键字
    /// </summary>
    public class SuggestionInfo
    {
        /// <summary>
        /// 建议关键字列表
        /// </summary>
        public string[] keywords;
        /// <summary>
        /// 建议城市列表
        /// </summary>
        public string[] cities;
    }

    /// <summary>
    /// 行政区信息
    /// </summary>
    public class DistrictInfo
    {
        /// <summary>
        /// 城市编码
        /// </summary>
        public string citycode;
        /// <summary>
        /// 区域编码
        /// <para>街道没有独有的adcode，均继承父类（区县）的adcode</para>
        /// </summary>
        public string adcode;
        /// <summary>
        /// 行政区名称
        /// </summary>
        public string name;
        /// <summary>
        /// 行政区边界坐标点
        /// </summary>
        public string polyline;
        /// <summary>
        /// 城市中心点
        /// </summary>
        public string center;
        /// <summary>
        /// 行政区划级别
        /// <para>country:国家
        /// province:省份（直辖市会在province和city显示）
        /// city:市（直辖市会在province和city显示）
        /// district:区县
        /// street:街道</para>
        /// </summary>
        public string level;
        /// <summary>
        /// 下级行政区列表
        /// </summary>
        public List<DistrictInfo> districts;
        /// <summary>
        /// 行政区划级别中文
        /// </summary>
        public string Level
        {
            get
            {
                return GaoDeConst.districtLevel[level];
            }
        }
    }
}
