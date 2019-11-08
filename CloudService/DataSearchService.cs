using Newtonsoft.Json;
using NugetLibs.GaoDeMap.CloudModel;
using NugetLibs.GaoDeMap.HelpModel;
using NugetLibs.HelpTool;
using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.CloudService
{
    /// <summary>
    /// 云图数据查询处理服务类
    /// </summary>
    public class DataSearchService : IDataSearchService
    {
        /// <summary>
        /// 检索附近指定时间范围内（最大24小时）上报用户位置的位置信息
        /// </summary>
        /// <param name="nearbyData">当前附近参数</param>
        /// <returns>上报用户位置的位置信息JSON</returns>
        public string AroundOriginalLocation(NearbyDataParam nearbyData)
        {
            string getUrl = "https://yuntuapi.amap.com/nearby/around?{0}";
            string paras = nearbyData.GenerateParam();
            getUrl = string.Format(getUrl, paras);
            string jsonResult = WebRequestHelper.HttpGet(getUrl);
            return jsonResult;
        }

        /// <summary>
        /// 检索附近指定时间范围内（最大24小时）上报用户位置的位置信息
        /// </summary>
        /// <param name="nearbyData">当前附近参数</param>
        /// <returns>上报用户位置的位置信息结果</returns>
        public GaoDeBaseResult AroundLocation(NearbyDataParam nearbyData)
        {
            string jsonResult = AroundOriginalLocation(nearbyData);
            if (!string.IsNullOrWhiteSpace(jsonResult))
            {
                jsonResult = jsonResult.Replace("[]", "\"\"");
            }
            GaoDeBaseResult queryResult = JsonConvert.DeserializeObject<GaoDeBaseResult>(jsonResult);
            return queryResult;
        }

        /// <summary>
        /// 云图数据本地检索
        /// </summary>
        /// <param name="queryParam">本地检索参数</param>
        /// <returns>本地检索结果JSON</returns>
        public string LocalOriginalQuery(LocalSearchParam queryParam)
        {
            string getUrl = "https://yuntuapi.amap.com/datasearch/local?{0}";
            string paras = queryParam.GenerateParam();
            getUrl = string.Format(getUrl, paras);
            string jsonResult = WebRequestHelper.HttpGet(getUrl);
            return jsonResult;
        }

        /// <summary>
        /// 云图数据本地检索
        /// </summary>
        /// <param name="queryParam">本地检索参数</param>
        /// <returns>本地检索结果对象</returns>
        public DataSearchResult LocalQuery(LocalSearchParam queryParam)
        {
            string jsonResult = LocalOriginalQuery(queryParam);
            if (!string.IsNullOrWhiteSpace(jsonResult))
            {
                jsonResult = jsonResult.Replace("[]", "\"\"");
            }
            DataSearchResult queryResult = JsonConvert.DeserializeObject<DataSearchResult>(jsonResult);
            return queryResult;
        }

        /// <summary>
        /// 云图数据周边检索
        /// </summary>
        /// <param name="queryParam">周边检索参数</param>
        /// <returns>周边检索结果JSON</returns>
        public string AroundOriginalQuery(AroundSearchParam queryParam)
        {
            string getUrl = "https://yuntuapi.amap.com/datasearch/around?{0}";
            string paras = queryParam.GenerateParam();
            getUrl = string.Format(getUrl, paras);
            string jsonResult = WebRequestHelper.HttpGet(getUrl);
            return jsonResult;
        }

        /// <summary>
        /// 云图数据周边检索
        /// </summary>
        /// <param name="queryParam">周边检索参数</param>
        /// <returns>周边检索结果对象</returns>
        public DataSearchResult AroundQuery(AroundSearchParam queryParam)
        {
            string jsonResult = AroundOriginalQuery(queryParam);
            if (!string.IsNullOrWhiteSpace(jsonResult))
            {
                jsonResult = jsonResult.Replace("[]", "\"\"");
            }
            DataSearchResult queryResult = JsonConvert.DeserializeObject<DataSearchResult>(jsonResult);
            return queryResult;
        }

        /// <summary>
        /// 云图数据多边形检索
        /// </summary>
        /// <param name="queryParam">多边形检索参数</param>
        /// <returns>多边形检索结果JSON</returns>
        public string PolygonOriginalQuery(PolygonSearchParam queryParam)
        {
            string getUrl = "https://yuntuapi.amap.com/datasearch/polygon?{0}";
            string paras = queryParam.GenerateParam();
            getUrl = string.Format(getUrl, paras);
            string jsonResult = WebRequestHelper.HttpGet(getUrl);
            return jsonResult;
        }

        /// <summary>
        /// 云图数据多边形检索
        /// </summary>
        /// <param name="queryParam">多边形检索参数</param>
        /// <returns>多边形检索结果对象</returns>
        public DataSearchResult PolygonQuery(PolygonSearchParam queryParam)
        {
            string jsonResult = PolygonOriginalQuery(queryParam);
            if (!string.IsNullOrWhiteSpace(jsonResult))
            {
                jsonResult = jsonResult.Replace("[]", "\"\"");
            }
            DataSearchResult queryResult = JsonConvert.DeserializeObject<DataSearchResult>(jsonResult);
            return queryResult;
        }

        /// <summary>
        /// 云图数据id检索（poi详情检索）检索
        /// </summary>
        /// <param name="queryParam">id检索（poi详情检索）检索参数</param>
        /// <returns>id检索（poi详情检索）检索结果JSON</returns>
        public string IDOriginalQuery(IDSearchParam queryParam)
        {
            string getUrl = "https://yuntuapi.amap.com/datasearch/id?{0}";
            string paras = queryParam.GenerateParam();
            getUrl = string.Format(getUrl, paras);
            string jsonResult = WebRequestHelper.HttpGet(getUrl);
            return jsonResult;
        }

        /// <summary>
        /// 云图数据id检索（poi详情检索）检索
        /// </summary>
        /// <param name="queryParam">id检索（poi详情检索）检索参数</param>
        /// <returns>id检索（poi详情检索）检索结果对象</returns>
        public DataSearchResult IDQuery(IDSearchParam queryParam)
        {
            string jsonResult = IDOriginalQuery(queryParam);
            if (!string.IsNullOrWhiteSpace(jsonResult))
            {
                jsonResult = jsonResult.Replace("[]", "\"\"");
            }
            DataSearchResult queryResult = JsonConvert.DeserializeObject<DataSearchResult>(jsonResult);
            return queryResult;
        }

        /// <summary>
        /// 云图按条件检索数据（可遍历整表数据）
        /// </summary>
        /// <param name="queryParam">检索参数</param>
        /// <returns>检索结果JSON</returns>
        public string AllOriginalQuery(AllSearchParam queryParam)
        {
            string getUrl = "https://yuntuapi.amap.com/datamanage/data/list?{0}";
            string paras = queryParam.GenerateParam();
            getUrl = string.Format(getUrl, paras);
            string jsonResult = WebRequestHelper.HttpGet(getUrl);
            return jsonResult;
        }

        /// <summary>
        /// 云图按条件检索数据（可遍历整表数据）
        /// </summary>
        /// <param name="queryParam">检索参数</param>
        /// <returns>检索结果对象</returns>
        public DataSearchResult AllQuery(AllSearchParam queryParam)
        {
            string jsonResult = AllOriginalQuery(queryParam);
            if (!string.IsNullOrWhiteSpace(jsonResult))
            {
                jsonResult = jsonResult.Replace("[]", "\"\"");
            }
            DataSearchResult queryResult = JsonConvert.DeserializeObject<DataSearchResult>(jsonResult);
            return queryResult;
        }

        /// <summary>
        /// 云图省数据分布检索
        /// </summary>
        /// <param name="queryParam">省数据分布检索参数</param>
        /// <returns>省数据分布检索结果JSON</returns>
        public string ProvinceOriginalQuery(ProvinceSearchParam queryParam)
        {
            string getUrl = "https://yuntuapi.amap.com/datasearch/statistics/province?{0}";
            string paras = queryParam.GenerateParam();
            getUrl = string.Format(getUrl, paras);
            string jsonResult = WebRequestHelper.HttpGet(getUrl);
            return jsonResult;
        }

        /// <summary>
        /// 云图省数据分布检索
        /// </summary>
        /// <param name="queryParam">省数据分布检索参数</param>
        /// <returns>省数据分布检索结果对象</returns>
        public AreaSearchResult ProvinceQuery(ProvinceSearchParam queryParam)
        {
            string jsonResult = ProvinceOriginalQuery(queryParam);
            if (!string.IsNullOrWhiteSpace(jsonResult))
            {
                jsonResult = jsonResult.Replace("[]", "\"\"");
            }
            AreaSearchResult queryResult = JsonConvert.DeserializeObject<AreaSearchResult>(jsonResult);
            return queryResult;
        }

        /// <summary>
        /// 云图市数据分布检索
        /// </summary>
        /// <param name="queryParam">市数据分布检索参数</param>
        /// <returns>市数据分布检索结果JSON</returns>
        public string CityOriginalQuery(CitySearchParam queryParam)
        {
            string getUrl = "https://yuntuapi.amap.com/datasearch/statistics/city?{0}";
            string paras = queryParam.GenerateParam();
            getUrl = string.Format(getUrl, paras);
            string jsonResult = WebRequestHelper.HttpGet(getUrl);
            return jsonResult;
        }

        /// <summary>
        /// 云图市数据分布检索
        /// </summary>
        /// <param name="queryParam">市数据分布检索参数</param>
        /// <returns>市数据分布检索结果对象</returns>
        public AreaSearchResult CityQuery(CitySearchParam queryParam)
        {
            string jsonResult = CityOriginalQuery(queryParam);
            if (!string.IsNullOrWhiteSpace(jsonResult))
            {
                jsonResult = jsonResult.Replace("[]", "\"\"");
            }
            AreaSearchResult queryResult = JsonConvert.DeserializeObject<AreaSearchResult>(jsonResult);
            return queryResult;
        }

        /// <summary>
        /// 云图区县数据分布检索
        /// </summary>
        /// <param name="queryParam">区县数据分布检索参数</param>
        /// <returns>区县数据分布检索结果JSON</returns>
        public string DistrictOriginalQuery(DistrictSearchParam queryParam)
        {
            string getUrl = "https://yuntuapi.amap.com/datasearch/statistics/district?{0}";
            string paras = queryParam.GenerateParam();
            getUrl = string.Format(getUrl, paras);
            string jsonResult = WebRequestHelper.HttpGet(getUrl);
            return jsonResult;
        }

        /// <summary>
        /// 云图区县数据分布检索
        /// </summary>
        /// <param name="queryParam">区县数据分布检索参数</param>
        /// <returns>区县数据分布检索结果对象</returns>
        public AreaSearchResult DistrictQuery(DistrictSearchParam queryParam)
        {
            string jsonResult = DistrictOriginalQuery(queryParam);
            if (!string.IsNullOrWhiteSpace(jsonResult))
            {
                jsonResult = jsonResult.Replace("[]", "\"\"");
            }
            AreaSearchResult queryResult = JsonConvert.DeserializeObject<AreaSearchResult>(jsonResult);
            return queryResult;
        }
    }
}
