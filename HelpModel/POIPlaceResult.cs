using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.HelpModel
{
    /// <summary>
    /// 关键字搜索POI查询结果
    /// </summary>
    public class POIPlaceResult : GaoDeBaseResult
    {
        /// <summary>
        /// 返回结果数目
        /// </summary>
        public int count;
        /// <summary>
        /// 泛词搜索，指定城市的建议
        /// </summary>
        public CitySuggestion suggestion;
        /// <summary>
        /// POI信息列表
        /// </summary>
        public PoiDetailInfo[] pois;
    }

    /// <summary>
    /// 泛词搜索（如：美食）指定城市的建议
    /// </summary>
    public class CitySuggestion
    {
        /// <summary>
        /// 搜索关键字唯一ID
        /// </summary>
        public string[] keywords;
        /// <summary>
        /// 建议城市列表
        /// </summary>
        public SugCity[] cities;
    }

    /// <summary>
    /// 建议输入城市信息
    /// </summary>
    public class SugCity: CityCodeInfo
    {
        /// <summary>
        /// 该城市包含此关键字的个数
        /// </summary>
        public int num;
    }

    /// <summary>
    /// POI地址详细信息
    /// </summary>
    public class PoiDetailInfo
    {
        /// <summary>
        /// poi的唯一ID
        /// </summary>
        public string id;
        /// <summary>
        /// 父POI的ID，当前POI如果有父POI，则返回父POI的ID。可能为空
        /// </summary>
        public string parent;
        /// <summary>
        /// poi点名称
        /// </summary>
        public string name;
        /// <summary>
        /// 兴趣点类型
        /// <para>顺序为大类、中类、小类</para>
        /// <para>例如：餐饮服务;中餐厅;特色/地方风味餐厅</para>
        /// </summary>
        public string type;
        /// <summary>
        /// 兴趣点类型编码
        /// <para>例如：050118</para>
        /// </summary>
        public string typecode;
        /// <summary>
        /// 行业类型
        /// </summary>
        public string biz_type;
        /// <summary>
        /// 电话
        /// </summary>
        public string tel;
        /// <summary>
        /// 离中心点距离 单位：米
        /// </summary>
        public string distance;
        /// <summary>
        /// poi地址信息
        /// </summary>
        public string address;
        /// <summary>
        /// 经纬度，格式：X,Y
        /// </summary>
        public string location;
        /// <summary>
        /// 邮编，extensions=all的时候显示 
        /// </summary>
        public string postcode;
        /// <summary>
        /// 该POI的网址，extensions=all的时候显示
        /// </summary>
        public string website;
        /// <summary>
        /// 该POI的电子邮箱，extensions=all的时候显示
        /// </summary>
        public string email;
        /// <summary>
        /// poi所在省份编码，extensions=all的时候显示
        /// </summary>
        public string pcode;
        /// <summary>
        /// poi所在省份名称
        /// <para>若是直辖市的时候，此处直接显示市名，例如北京市</para>
        /// </summary>
        public string pname;
        /// <summary>
        /// 城市编码，extensions=all的时候显示
        /// </summary>
        public string citycode;
        /// <summary>
        /// 城市名，extensions=all的时候显示
        /// </summary>
        public string cityname;
        /// <summary>
        /// 区域编码，extensions=all的时候显示
        /// </summary>
        public string adcode;
        /// <summary>
        /// 区域名称，extensions=all的时候显示
        /// </summary>
        public string adname;
        /// <summary>
        /// 入口经纬度，extensions=all的时候显示
        /// </summary>
        public string entr_location;
        /// <summary>
        /// 出口经纬度，extensions=all的时候显示
        /// </summary>
        public string exit_location;
        /// <summary>
        /// 地图编号，extensions=all的时候显示
        /// </summary>
        public string navi_poiid;
        /// <summary>
        /// 地理格ID，extensions=all的时候显示
        /// </summary>
        public string gridcode;
        /// <summary>
        /// 别名，extensions=all的时候显示
        /// </summary>
        public string alias;
        /// <summary>
        /// 所在商圈，extensions=all的时候显示
        /// </summary>
        public string business_area;
        /// <summary>
        /// 停车场类型
        /// <para>仅在停车场类型POI的时候显示该字段</para>
        /// <para>展示停车场类型，包括：地下、地面、路边</para>
        /// <para>extensions=all 的时候显示 </para>
        /// </summary>
        public string parking_type;
        /// <summary>
        /// 该POI的特色内容
        /// <para>主要出现在POI为美食类的POI之中出现，此时代表特色菜</para>
        /// </summary>
        public string tag;
        /// <summary>
        /// 是否有室内地图标志
        /// </summary>
        public string indoor_map;
        /// <summary>
        /// 室内地图相关数据
        /// <para>当indoor_map=0时，字段为空</para>
        /// </summary>
        public IndoorData indoor_data;
        /// <summary>
        /// 深度信息，extensions=all的时候显示
        /// </summary>
        public BusinessExtData biz_ext;
        /// <summary>
        /// 照片相关信息
        /// </summary>
        public PhotoData[] photos;
    }

    /// <summary>
    /// 室内地图相关数据
    /// </summary>
    public class IndoorData
    {
        /// <summary>
        /// 当前POI的父级POI
        /// <para>如果当前POI为建筑物类POI，则cpid为自身POI ID；如果当前POI为商铺类POI，则cpid为其所在建筑物的POI ID</para>
        /// </summary>
        public string cpid;
        /// <summary>
        /// 楼层索引
        /// </summary>
        public int? floor;
        /// <summary>
        /// 所在楼层
        /// </summary>
        public int? truefloor;
    }

    /// <summary>
    /// 商业上道扩展数据
    /// </summary>
    public class BusinessExtData
    {
        /// <summary>
        /// 评分
        /// <para>仅存在于餐饮、酒店、景点、影院类POI之下</para>
        /// </summary>
        public decimal? rating;
        /// <summary>
        /// 人均消费
        /// <para>仅存在于餐饮、酒店、景点、影院类POI之下</para>
        /// </summary>
        public decimal? cost;
    }

    /// <summary>
    /// 照片相关信息
    /// </summary>
    public class PhotoData
    {
        /// <summary>
        /// 图片介绍
        /// </summary>
        public string title;
        /// <summary>
        /// 具体链接
        /// </summary>
        public string url;
    }
}
