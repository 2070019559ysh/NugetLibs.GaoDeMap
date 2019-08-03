using Newtonsoft.Json;
using NugetLibs.GaoDeMap.HelpModel;
using NugetLibs.HelpTool;
using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.WebService
{
    /// <summary>
    /// 搜索POI处理服务
    /// </summary>
    public class POIPlaceService : IPOIPlaceService
    {
        /// <summary>
        /// 关键字搜索POI信息
        /// </summary>
        /// <param name="queryParam">查询参数</param>
        /// <returns>搜索POI查询结果</returns>
        public string SearchOriginalPOIByText(POITextParam queryParam)
        {
            string getUrl = GaoDeConst.WebAPIHost + "/v3/place/text?{0}";
            string paras = queryParam.GenerateParams();
            getUrl = string.Format(getUrl, paras);
            string queryResult = WebRequestHelper.HttpGet(getUrl);
            return queryResult;
        }

        /// <summary>
        /// 关键字搜索POI信息
        /// </summary>
        /// <param name="queryParam">查询参数</param>
        /// <returns>搜索POI查询结果</returns>
        public POIPlaceResult SearchPOIByText(POITextParam queryParam)
        {
            queryParam.output = "JSON";
            string jsonResult = SearchOriginalPOIByText(queryParam);
            if (!string.IsNullOrWhiteSpace(jsonResult))
            {
                jsonResult = jsonResult.Replace("[]", "\"\"");
            }
            POIPlaceResult queryResult = JsonConvert.DeserializeObject<POIPlaceResult>(jsonResult);
            return queryResult;
        }

        /// <summary>
        /// 周边搜索POI信息
        /// </summary>
        /// <param name="queryParam">查询参数</param>
        /// <returns>搜索POI查询结果</returns>
        public string SearchOriginalPOIByAround(POIAroundParam queryParam)
        {
            string getUrl = GaoDeConst.WebAPIHost + "/v3/place/around?{0}";
            string paras = queryParam.GenerateParams();
            getUrl = string.Format(getUrl, paras);
            string queryResult = WebRequestHelper.HttpGet(getUrl);
            return queryResult;
        }

        /// <summary>
        /// 周边搜索POI信息
        /// </summary>
        /// <param name="queryParam">查询参数</param>
        /// <returns>搜索POI查询结果</returns>
        public POIPlaceResult SearchPOIByAround(POIAroundParam queryParam)
        {
            queryParam.output = "JSON";
            string jsonResult = SearchOriginalPOIByAround(queryParam);
            if (!string.IsNullOrWhiteSpace(jsonResult))
            {
                jsonResult = jsonResult.Replace("[]", "\"\"");
            }
            POIPlaceResult queryResult = JsonConvert.DeserializeObject<POIPlaceResult>(jsonResult);
            return queryResult;
        }

        /// <summary>
        /// 多边形搜索POI信息
        /// </summary>
        /// <param name="queryParam">查询参数</param>
        /// <returns>搜索POI查询结果</returns>
        public string SearchOriginalPOIByPolygon(POIPolygonParam queryParam)
        {
            string getUrl = GaoDeConst.WebAPIHost + "/v3/place/polygon?{0}";
            string paras = queryParam.GenerateParams();
            getUrl = string.Format(getUrl, paras);
            string queryResult = WebRequestHelper.HttpGet(getUrl);
            return queryResult;
        }

        /// <summary>
        /// 多边形搜索POI信息
        /// </summary>
        /// <param name="queryParam">查询参数</param>
        /// <returns>搜索POI查询结果</returns>
        public POIPlaceResult SearchPOIByPolygon(POIPolygonParam queryParam)
        {
            queryParam.output = "JSON";
            string jsonResult = SearchOriginalPOIByPolygon(queryParam);
            if (!string.IsNullOrWhiteSpace(jsonResult))
            {
                jsonResult = jsonResult.Replace("[]", "\"\"");
            }
            POIPlaceResult queryResult = JsonConvert.DeserializeObject<POIPlaceResult>(jsonResult);
            return queryResult;
        }

        /// <summary>
        /// ID查询POI信息
        /// </summary>
        /// <param name="queryParam">查询参数</param>
        /// <returns>搜索POI查询结果</returns>
        public string SearchOriginalPOIByDetail(POIDetailParam queryParam)
        {
            string getUrl = GaoDeConst.WebAPIHost + "/v3/place/detail?{0}";
            string paras = queryParam.GenerateParams();
            getUrl = string.Format(getUrl, paras);
            string queryResult = WebRequestHelper.HttpGet(getUrl);
            return queryResult;
        }

        /// <summary>
        /// ID查询POI信息
        /// </summary>
        /// <param name="queryParam">查询参数</param>
        /// <returns>搜索POI查询结果</returns>
        public POIPlaceResult SearchPOIByDetail(POIDetailParam queryParam)
        {
            queryParam.output = "JSON";
            string jsonResult = SearchOriginalPOIByDetail(queryParam);
            if (!string.IsNullOrWhiteSpace(jsonResult))
            {
                jsonResult = jsonResult.Replace("[]", "\"\"");
            }
            POIPlaceResult queryResult = JsonConvert.DeserializeObject<POIPlaceResult>(jsonResult);
            return queryResult;
        }
    }
}
