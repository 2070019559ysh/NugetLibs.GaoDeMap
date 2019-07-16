using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.HelpModel
{
    /// <summary>
    /// 地理编码信息结果对象
    /// </summary>
    public class GeoCodeResult : GaoDeBaseResult
    {
        /// <summary>
        /// 返回结果数目
        /// </summary>
        public int count;
        /// <summary>
        /// 地理编码信息列表
        /// </summary>
        public List<GeoCodeInfo> geocodes;
    }

    /// <summary>
    /// 地理编码信息
    /// </summary>
    public class GeoCodeInfo
    {
        /// <summary>
        /// 结构化地址信息，格式：省份＋城市＋区县＋城镇＋乡村＋街道＋门牌号码
        /// </summary>
        public string formatted_address;
        /// <summary>
        /// 地址所在的国家
        /// </summary>
        public string country;
        /// <summary>
        /// 地址所在的省份名
        /// </summary>
        public string province;
        /// <summary>
        /// 地址所在的城市名
        /// </summary>
        public string city;
        /// <summary>
        /// 城市编码
        /// </summary>
        public string citycode;
        /// <summary>
        /// 地址所在的区
        /// </summary>
        public string district;
        /// <summary>
        /// 地址所在的乡镇
        /// </summary>
        public string[] township;
        /// <summary>
        /// 地址所在的街道
        /// </summary>
        public string[] street;
        /// <summary>
        /// 地址所在的门牌
        /// </summary>
        public string[] number;
        /// <summary>
        /// 区域编码
        /// </summary>
        public string adcode;
        /// <summary>
        /// 坐标点：经度，纬度
        /// </summary>
        public string location;
        /// <summary>
        /// 匹配级别
        /// </summary>
        public string level;
    }
}
