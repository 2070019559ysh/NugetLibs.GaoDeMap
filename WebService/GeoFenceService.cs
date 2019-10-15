using Newtonsoft.Json;
using NugetLibs.GaoDeMap.HelpModel;
using NugetLibs.HelpTool;
using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.WebService
{
    /// <summary>
    /// 地理围栏数据处理服务
    /// </summary>
    public class GeoFenceService : IGeoFenceService
    {
        /// <summary>
        /// 创建地理围栏
        /// </summary>
        /// <param name="fenceInfo">地理围栏信息</param>
        /// <returns>创建结果</returns>
        public GaoDeErrResult<CreateFenceResult> CreateFence(GeoFenceInfo fenceInfo)
        {
            string url = GaoDeConst.WebAPIHost + "/v4/geofence/meta?key=" + GaoDeConfig.AppKey;
            GaoDeErrResult<CreateFenceResult> result = WebRequestHelper.PostHttp<GaoDeErrResult<CreateFenceResult>>(url, fenceInfo);
            return result;
        }

        /// <summary>
        /// 查询地理围栏
        /// </summary>
        /// <param name="queryParam">查询参数</param>
        /// <returns>地理围栏结果</returns>
        public GaoDeErrResult<FenceQueryResult> FenceQuery(FenceQueryParam queryParam)
        {
            queryParam.output = "JSON";
            string getUrl = GaoDeConst.WebAPIHost + "/v4/geofence/meta?{0}";
            string paras = queryParam.GenerateParams();
            getUrl = string.Format(getUrl, paras);
            var queryResult = WebRequestHelper.HttpGet<GaoDeErrResult<FenceQueryResult>>(getUrl);
            return queryResult;
        }

        /// <summary>
        /// 更新地理围栏
        /// </summary>
        /// <param name="gid">围栏全局id</param>
        /// <param name="fenceInfo">地理围栏信息</param>
        /// <returns>更新结果</returns>
        public GaoDeErrResult<UpdateFenceResult> UpdateFence(string gid, GeoFenceInfo fenceInfo)
        {
            string url = GaoDeConst.WebAPIHost + "/v4/geofence/meta?key=" + GaoDeConfig.AppKey + "&gid=" + gid;
            string jsonResult = WebRequestHelper.PatchHttp(url, fenceInfo);
            GaoDeErrResult<UpdateFenceResult> updateResult = JsonConvert.DeserializeObject<GaoDeErrResult<UpdateFenceResult>>(jsonResult);
            return updateResult;
        }

        /// <summary>
        /// 围栏启动或停止地理围栏
        /// </summary>
        /// <param name="gid">围栏全局id</param>
        /// <param name="isEnabled">是否启用，否则停止</param>
        /// <returns>启动或停止结果</returns>
        public GaoDeErrResult<UpdateFenceResult> EnableFence(string gid, bool isEnabled = true)
        {
            string url = GaoDeConst.WebAPIHost + "/v4/geofence/meta?key=" + GaoDeConfig.AppKey + "&gid=" + gid;
            string jsonResult = WebRequestHelper.PatchHttp(url, new { enable = isEnabled });
            GaoDeErrResult<UpdateFenceResult> updateResult = JsonConvert.DeserializeObject<GaoDeErrResult<UpdateFenceResult>>(jsonResult);
            return updateResult;
        }

        /// <summary>
        /// 删除地理围栏
        /// </summary>
        /// <param name="gid">围栏全局id</param>
        /// <returns>删除结果</returns>
        public GaoDeErrResult<UpdateFenceResult> DeleteFence(string gid)
        {
            string url = GaoDeConst.WebAPIHost + "/v4/geofence/meta?key=" + GaoDeConfig.AppKey + "&gid=" + gid;
            string jsonResult = WebRequestHelper.DeleteHttp(url);
            GaoDeErrResult<UpdateFenceResult> updateResult = JsonConvert.DeserializeObject<GaoDeErrResult<UpdateFenceResult>>(jsonResult);
            return updateResult;
        }

        /// <summary>
        /// 查询地理围栏
        /// </summary>
        /// <param name="queryParam">查询参数</param>
        /// <returns>地理围栏结果</returns>
        public GaoDeErrResult<FenceMonitorResult> FenceQuery(FenceMonitorParam queryParam)
        {
            queryParam.output = "JSON";
            string getUrl = GaoDeConst.WebAPIHost + "/v4/geofence/status?{0}";
            string paras = queryParam.GenerateParams();
            getUrl = string.Format(getUrl, paras);
            var queryResult = WebRequestHelper.HttpGet<GaoDeErrResult<FenceMonitorResult>>(getUrl);
            return queryResult;
        }
    }
}
