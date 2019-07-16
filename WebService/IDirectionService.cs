using NugetLibs.GaoDeMap.HelpModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.WebService
{
    /// <summary>
    /// 路径规划处理服务接口声明
    /// </summary>
    public interface IDirectionService
    {
        /// <summary>
        /// 步行路径规划
        /// </summary>
        /// <param name="planParam">规划路径参数</param>
        /// <returns>路径规划结果</returns>
        string WalkOriginalPlanning(WalkPlanParam planParam);

        /// <summary>
        /// 步行路径规划
        /// </summary>
        /// <param name="planParam">规划路径参数</param>
        /// <returns>路径规划结果</returns>
        WalkPlanResult WalkPlanning(WalkPlanParam planParam);

        /// <summary>
        /// 公交路径规划
        /// </summary>
        /// <param name="planParam">规划路径参数</param>
        /// <returns>路径规划结果</returns>
        string TransitOriginalPlanning(TransitPlanParam planParam);

        /// <summary>
        /// 公交路径规划
        /// </summary>
        /// <param name="planParam">规划路径参数</param>
        /// <returns>路径规划结果</returns>
        TransitPlanResult TransitPlanning(TransitPlanParam planParam);

        /// <summary>
        /// 驾车路径规划
        /// </summary>
        /// <param name="planParam">规划路径参数</param>
        /// <returns>路径规划结果</returns>
        string DrivingOriginalPlanning(DrivingPlanParam planParam);

        /// <summary>
        /// 驾车路径规划
        /// </summary>
        /// <param name="planParam">规划路径参数</param>
        /// <returns>路径规划结果</returns>
        DrivingPlanResult DrivingPlanning(DrivingPlanParam planParam);

        /// <summary>
        /// 骑行路径规划
        /// </summary>
        /// <param name="planParam">规划路径参数</param>
        /// <returns>路径规划结果</returns>
        string BicyclingOriginalPlanning(BicyclingPlanParam planParam);

        /// <summary>
        /// 骑行路径规划
        /// </summary>
        /// <param name="planParam">规划路径参数</param>
        /// <returns>路径规划结果</returns>
        BicyclingPlanResult BicyclingPlanning(BicyclingPlanParam planParam);

        /// <summary>
        /// 货车路径规划
        /// </summary>
        /// <param name="planParam">规划路径参数</param>
        /// <returns>路径规划结果</returns>
        string TruckOriginalPlanning(TruckPlanParam planParam);

        /// <summary>
        /// 货车路径规划
        /// </summary>
        /// <param name="planParam">规划路径参数</param>
        /// <returns>路径规划结果</returns>
        TruckPlanResult TruckPlanning(TruckPlanParam planParam);

        /// <summary>
        /// 距离测量
        /// </summary>
        /// <param name="distanceParam">距离测量参数</param>
        /// <returns>距离测量结果</returns>
        string DistanceOriginalMeasure(DistanceParam distanceParam);

        /// <summary>
        /// 距离测量
        /// </summary>
        /// <param name="distanceParam">距离测量参数</param>
        /// <returns>距离测量结果</returns>
        DistanceResult DistanceMeasure(DistanceParam distanceParam);
    }
}
