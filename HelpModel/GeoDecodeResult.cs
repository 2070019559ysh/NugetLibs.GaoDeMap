using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.HelpModel
{
    /// <summary>
    /// 逆地理编码信息结果对象
    /// </summary>
    public class GeoDecodeResult : GaoDeBaseResult
    {
        /// <summary>
        /// 逆地理编码列表
        /// </summary>
        //public List<ReGeoCodeInfo> regeocodes;
        /// <summary>
        /// 逆地理编码信息
        /// </summary>
        public ReGeoCodeInfo regeocode;
    }

    /// <summary>
    /// 逆地理编码信息
    /// </summary>
    public class ReGeoCodeInfo
    {
        /// <summary>
        /// 结构化地址信息，格式：省份＋城市＋区县＋城镇＋乡村＋街道＋门牌号码
        /// </summary>
        public string formatted_address;
        /// <summary>
        /// 地址元素信息
        /// </summary>
        public AddressComponent addressComponent;

        /// <summary>
        /// 道路信息列表
        /// </summary>
        public List<RoadInfo> roads;
        /// <summary>
        /// 道路交叉口列表
        /// </summary>
        public List<Roadinter> roadinters;
        /// <summary>
        /// poi信息列表
        /// </summary>
        public List<PoiInfo> pois;
        /// <summary>
        /// aoi信息列表
        /// </summary>
        public List<AoiInfo> aois;
    }

    /// <summary>
    /// 地址元素
    /// </summary>
    public class AddressComponent
    {
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
        /// 区域编码
        /// </summary>
        public string adcode;
        /// <summary>
        /// 地址所在的乡镇
        /// </summary>
        public string township;
        /// <summary>
        /// 乡镇街道编码
        /// </summary>
        public string towncode;
        /// <summary>
        /// 社区信息信息
        /// </summary>
        public Neighborhood neighborhood;
        /// <summary>
        /// 楼信息信息
        /// </summary>
        public Building building;
        /// <summary>
        /// 门牌信息
        /// </summary>
        public StreetNumber streetNumber;
        /// <summary>
        /// 所属海域信息
        /// </summary>
        public string seaArea;
        /// <summary>
        /// 经纬度所属商圈列表
        /// </summary>
        //public List<BusinessArea> businessAreas;
    }

    /// <summary>
    /// 社区信息
    /// </summary>
    public class Neighborhood
    {
        /// <summary>
        /// 社区名称
        /// </summary>
        public string[] name;
        /// <summary>
        /// POI类型
        /// </summary>
        public string[] type;
    }

    /// <summary>
    /// 社区信息
    /// </summary>
    public class Building
    {
        /// <summary>
        /// 建筑名称
        /// </summary>
        public string[] name;
        /// <summary>
        /// POI类型
        /// </summary>
        public string[] type;
    }

    /// <summary>
    /// 门牌信息
    /// </summary>
    public class StreetNumber
    {
        /// <summary>
        /// 街道名称
        /// </summary>
        public string street;
        /// <summary>
        /// 门牌号
        /// </summary>
        public string number;
        /// <summary>
        /// 坐标点 经纬度坐标点：经度，纬度
        /// </summary>
        public string location;
        /// <summary>
        /// 方向 坐标点所处街道方位
        /// </summary>
        public string direction;
        /// <summary>
        /// 门牌地址到请求坐标的距离 单位：米
        /// </summary>
        public string distance;
    }

    /// <summary>
    /// 经纬度所属商圈
    /// </summary>
    public class BusinessArea
    {
        /// <summary>
        /// 商圈信息
        /// </summary>
        public string businessArea;
        /// <summary>
        /// 商圈中心点经纬度
        /// </summary>
        public string location;
        /// <summary>
        /// 商圈名称
        /// </summary>
        public string name;
        /// <summary>
        /// 商圈所在区域的adcode
        /// </summary>
        public string id;
    }

    /// <summary>
    /// 道路信息
    /// </summary>
    public class RoadObj
    {
        /// <summary>
        /// 道路信息
        /// </summary>
        public RoadInfo road;
    }

    /// <summary>
    /// 道路信息
    /// </summary>
    public class RoadInfo
    {
        /// <summary>
        /// 道路id
        /// </summary>
        public string id;
        /// <summary>
        /// 道路名称
        /// </summary>
        public string name;
        /// <summary>
        /// 道路到请求坐标的距离 单位：米
        /// </summary>
        public string distance;
        /// <summary>
        /// 方位 输入点和此路的相对方位
        /// </summary>
        public string direction;
        /// <summary>
        /// 坐标点
        /// </summary>
        public string location;
    }

    /// <summary>
    /// 道路交叉口
    /// </summary>
    public class RoadinterObj
    {
        /// <summary>
        /// 道路交叉口
        /// </summary>
        public Roadinter roadinter;
    }

    /// <summary>
    /// 道路交叉口
    /// </summary>
    public class Roadinter
    {
        /// <summary>
        /// 交叉路口到请求坐标的距离 单位：米
        /// </summary>
        public string distance;
        /// <summary>
        /// 方位 输入点相对路口的方位
        /// </summary>
        public string direction;
        /// <summary>
        /// 路口经纬度
        /// </summary>
        public string location;
        /// <summary>
        /// 第一条道路id
        /// </summary>
        public string first_id;
        /// <summary>
        /// 第一条道路名称
        /// </summary>
        public string first_name;
        /// <summary>
        /// 第二条道路id
        /// </summary>
        public string second_id;
        /// <summary>
        /// 第二条道路名称
        /// </summary>
        public string second_name;
    }

    /// <summary>
    /// poi信息
    /// </summary>
    public class PoiInfo
    {
        /// <summary>
        /// poi的id
        /// </summary>
        public string id;
        /// <summary>
        /// poi点名称
        /// </summary>
        public string name;
        /// <summary>
        /// poi类型
        /// </summary>
        public string type;
        /// <summary>
        /// 电话
        /// </summary>
        public string tel;
        /// <summary>
        /// 该POI到请求坐标的距离 单位：米
        /// </summary>
        public string distance;
        /// <summary>
        /// 方向 为输入点相对建筑物的方位
        /// </summary>
        public string direction;
        /// <summary>
        /// poi地址信息
        /// </summary>
        public string address;
        /// <summary>
        /// 坐标点
        /// </summary>
        public string location;
        /// <summary>
        /// poi所在商圈名称
        /// </summary>
        public string[] businessarea;
    }

    /// <summary>
    /// aoi信息
    /// </summary>
    public class AoiObj
    {
        /// <summary>
        /// aoi信息
        /// </summary>
        public AoiInfo aoi;
    }

    /// <summary>
    /// aoi信息
    /// </summary>
    public class AoiInfo
    {
        /// <summary>
        /// 所属 aoi的id
        /// </summary>
        public string id;
        /// <summary>
        /// 所属 aoi 名称
        /// </summary>
        public string name;
        /// <summary>
        /// 所属 aoi 所在区域编码
        /// </summary>
        public string adcode;
        /// <summary>
        /// 所属 aoi 中心点坐标
        /// </summary>
        public string location;
        /// <summary>
        /// 所属aoi点面积 单位：平方米
        /// </summary>
        public string area;
        /// <summary>
        /// 输入经纬度是否在aoi面之中
        /// <para>0，代表在aoi内；其余整数代表距离AOI的距离</para>
        /// </summary>
        public int distance;
    }
}
