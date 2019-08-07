using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.HelpModel
{
    /// <summary>
    /// Web服务API常量
    /// </summary>
    public class WebAPI
    {
        /// <summary>
        /// 地理编码-v3【body as GeoCodeResult】
        /// </summary>
        public const string GEO_CODE = "/v3/geocode/geo";
        /// <summary>
        /// 逆地理编码-v3【body as GeoDecodeResult】
        /// </summary>
        public const string GEO_DECODE = "/v3/geocode/regeo";
        /// <summary>
        /// 步行路径规划-v3【body as WalkPlanResult】
        /// </summary>
        public const string PLAN_WALKING = "/v3/direction/walking";
        /// <summary>
        /// 公交路径规划-v3【body as TransitPlanResult】
        /// </summary>
        public const string PLAN_TRANSIT = "/v3/direction/transit/integrated";
        /// <summary>
        /// 驾车路径规划-v3【body as DrivingPlanResult】
        /// </summary>
        public const string PLAN_DRIVING = "/v3/direction/driving";
        /// <summary>
        /// 骑行路径规划-v4【body as BicyclingPlanResult】
        /// </summary>
        public const string PLAN_BICYCLING = "/v4/direction/bicycling";
        /// <summary>
        /// 货车路径规划-v4【body as TruckPlanResult】
        /// </summary>
        public const string PLAN_TRUCK = "/v4/direction/truck";
        /// <summary>
        /// 路径距离测量-v3【body as DistanceResult】
        /// </summary>
        public const string PLAN_DISTANCE = "/v3/distance";
        /// <summary>
        /// 行政区域查询-v3【body as AdminRegionQueryResult】
        /// </summary>
        public const string ADMIN_REGION = "/v3/config/district";
        /// <summary>
        /// 关键字搜索-v3【body as POIPlaceResult】
        /// </summary>
        public const string POI_TEXT = "/v3/place/text";
        /// <summary>
        /// 周边搜索-v3【body as POIPlaceResult】
        /// </summary>
        public const string POI_AROUND = "/v3/place/around";
        /// <summary>
        /// 多边形搜索-v3【body as POIPlaceResult】
        /// </summary>
        public const string POI_POLYGON = "/v3/place/polygon";
        /// <summary>
        /// ID查询-v3【body as POIPlaceResult】
        /// </summary>
        public const string POI_DETAIL = "/v3/place/detail";
        /// <summary>
        /// IP定位-v3【body as IPCityResult】
        /// </summary>
        public const string IP_CITY = "/v3/ip";
        /// <summary>
        /// 地图坐标转换-v3【body as CoordinateResult】
        /// </summary>
        public const string COORDINATE_CONVERT = "/v3/assistant/coordinate/convert";
        /// <summary>
        /// 天气查询-v3【body as WeatherResult】
        /// </summary>
        public const string WEATHER_QUERY = "/v3/weather/weatherInfo";
        /// <summary>
        /// 输入提示-v3【body as InputTipsResult】
        /// </summary>
        public const string INPUT_TIPS = "/v3/assistant/inputtips";

        /// <summary>
        /// 接口返回结果的类型集合
        /// </summary>
        public static Dictionary<string, Type> apiResultTypeDic = new Dictionary<string, Type>()
        {
            { GEO_CODE,typeof(GeoCodeResult) },{ GEO_DECODE,typeof(GeoDecodeResult) },
            { PLAN_WALKING,typeof(WalkPlanResult) },{ PLAN_TRANSIT,typeof(TransitPlanResult) },
            { PLAN_DRIVING,typeof(DrivingPlanResult) },{ PLAN_BICYCLING,typeof(BicyclingPlanResult) },
            { PLAN_TRUCK,typeof(TruckPlanResult) },{ PLAN_DISTANCE,typeof(DistanceResult) },
            { ADMIN_REGION,typeof(AdminRegionQueryResult) },
            { POI_TEXT,typeof(POIPlaceResult) },{ POI_AROUND,typeof(POIPlaceResult) },
            { POI_POLYGON,typeof(POIPlaceResult) },{ POI_DETAIL,typeof(POIPlaceResult) },
            { IP_CITY,typeof(IPCityResult) },{ COORDINATE_CONVERT,typeof(CoordinateResult) },
            { WEATHER_QUERY,typeof(WeatherResult) },{ INPUT_TIPS,typeof(InputTipsResult) }
        };
    }
}
