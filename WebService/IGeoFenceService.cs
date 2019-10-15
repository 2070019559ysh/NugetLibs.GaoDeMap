using NugetLibs.GaoDeMap.HelpModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.WebService
{
    /// <summary>
    /// 地理围栏数据处理服务接口声明
    /// </summary>
    public interface IGeoFenceService
    {
        /// <summary>
        /// 创建地理围栏
        /// </summary>
        /// <param name="fenceInfo">地理围栏信息</param>
        /// <returns>创建结果</returns>
        GaoDeErrResult<CreateFenceResult> CreateFence(GeoFenceInfo fenceInfo);

        /// <summary>
        /// 查询地理围栏
        /// </summary>
        /// <param name="queryParam">查询参数</param>
        /// <returns>地理围栏结果</returns>
        GaoDeErrResult<FenceQueryResult> FenceQuery(FenceQueryParam queryParam);

        /// <summary>
        /// 更新地理围栏
        /// </summary>
        /// <param name="gid">围栏全局id</param>
        /// <param name="fenceInfo">地理围栏信息</param>
        /// <returns>更新结果</returns>
        GaoDeErrResult<UpdateFenceResult> UpdateFence(string gid, GeoFenceInfo fenceInfo);

        /// <summary>
        /// 围栏启动或停止地理围栏
        /// </summary>
        /// <param name="gid">围栏全局id</param>
        /// <param name="isEnabled">是否启用，否则停止</param>
        /// <returns>启动或停止结果</returns>
        GaoDeErrResult<UpdateFenceResult> EnableFence(string gid, bool isEnabled = true);

        /// <summary>
        /// 删除地理围栏
        /// </summary>
        /// <param name="gid">围栏全局id</param>
        /// <returns>删除结果</returns>
        GaoDeErrResult<UpdateFenceResult> DeleteFence(string gid);

        /// <summary>
        /// 查询地理围栏
        /// </summary>
        /// <param name="queryParam">查询参数</param>
        /// <returns>地理围栏结果</returns>
        GaoDeErrResult<FenceMonitorResult> FenceQuery(FenceMonitorParam queryParam);
    }
}
