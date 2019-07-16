using Newtonsoft.Json;
using NugetLibs.GaoDeMap.HelpModel;
using NugetLibs.HelpTool;
using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.WebService
{
    /// <summary>
    /// 路径规划处理服务
    /// </summary>
    public class DirectionService : IDirectionService
    {
        /// <summary>
        /// 步行路径规划
        /// </summary>
        /// <param name="planParam">规划路径参数</param>
        /// <returns>路径规划结果</returns>
        public string WalkOriginalPlanning(WalkPlanParam planParam)
        {
            string getUrl = "https://restapi.amap.com/v3/direction/walking?{0}";
            string paras = planParam.GenerateParams();
            getUrl = string.Format(getUrl, paras);
            string planResult = WebRequestHelper.HttpGet(getUrl);
            return planResult;
        }

        /// <summary>
        /// 步行路径规划
        /// </summary>
        /// <param name="planParam">规划路径参数</param>
        /// <returns>路径规划结果</returns>
        public WalkPlanResult WalkPlanning(WalkPlanParam planParam)
        {
            planParam.output = "JSON";
            string jsonResult = WalkOriginalPlanning(planParam);
            if (!string.IsNullOrWhiteSpace(jsonResult))
            {
                jsonResult = jsonResult.Replace("[]", "\"\"");
            }
            WalkPlanResult planResult = JsonConvert.DeserializeObject<WalkPlanResult>(jsonResult);
            return planResult;
        }

        /// <summary>
        /// 公交路径规划
        /// </summary>
        /// <param name="planParam">规划路径参数</param>
        /// <returns>路径规划结果</returns>
        public string TransitOriginalPlanning(TransitPlanParam planParam)
        {
            string getUrl = "https://restapi.amap.com/v3/direction/transit/integrated?{0}";
            string paras = planParam.GenerateParams();
            getUrl = string.Format(getUrl, paras);
            string planResult = WebRequestHelper.HttpGet(getUrl);
            return planResult;
        }

        /// <summary>
        /// 公交路径规划
        /// </summary>
        /// <param name="planParam">规划路径参数</param>
        /// <returns>路径规划结果</returns>
        public TransitPlanResult TransitPlanning(TransitPlanParam planParam)
        {
            planParam.output = "JSON";
            string jsonResult = TransitOriginalPlanning(planParam);
            if (!string.IsNullOrWhiteSpace(jsonResult))
            {
                jsonResult = jsonResult.Replace("[]", "\"\"");
            }
            TransitPlanResult planResult = JsonConvert.DeserializeObject<TransitPlanResult>(jsonResult);
            return planResult;
        }

        /// <summary>
        /// 驾车路径规划
        /// </summary>
        /// <param name="planParam">规划路径参数</param>
        /// <returns>路径规划结果</returns>
        public string DrivingOriginalPlanning(DrivingPlanParam planParam)
        {
            string getUrl = "https://restapi.amap.com/v3/direction/driving?{0}";
            string paras = planParam.GenerateParams();
            getUrl = string.Format(getUrl, paras);
            string planResult = WebRequestHelper.HttpGet(getUrl);
            return planResult;
        }

        /// <summary>
        /// 驾车路径规划
        /// </summary>
        /// <param name="planParam">规划路径参数</param>
        /// <returns>路径规划结果</returns>
        public DrivingPlanResult DrivingPlanning(DrivingPlanParam planParam)
        {
            planParam.output = "JSON";
            string jsonResult = DrivingOriginalPlanning(planParam);
            if (!string.IsNullOrWhiteSpace(jsonResult))
            {
                jsonResult = jsonResult.Replace("[]", "\"\"");
            }
            DrivingPlanResult planResult = JsonConvert.DeserializeObject<DrivingPlanResult>(jsonResult);
            return planResult;
        }

        /// <summary>
        /// 骑行路径规划
        /// </summary>
        /// <param name="planParam">规划路径参数</param>
        /// <returns>路径规划结果</returns>
        public string BicyclingOriginalPlanning(BicyclingPlanParam planParam)
        {
            string getUrl = "https://restapi.amap.com/v4/direction/bicycling?{0}";
            string paras = planParam.GenerateParams();
            getUrl = string.Format(getUrl, paras);
            string planResult = WebRequestHelper.HttpGet(getUrl);
            return planResult;
        }

        /// <summary>
        /// 骑行路径规划
        /// </summary>
        /// <param name="planParam">规划路径参数</param>
        /// <returns>路径规划结果</returns>
        public BicyclingPlanResult BicyclingPlanning(BicyclingPlanParam planParam)
        {
            planParam.output = "JSON";
            string jsonResult = BicyclingOriginalPlanning(planParam);
            if (!string.IsNullOrWhiteSpace(jsonResult))
            {
                jsonResult = jsonResult.Replace("[]", "\"\"");
            }
            BicyclingPlanResult planResult = JsonConvert.DeserializeObject<BicyclingPlanResult>(jsonResult);
            return planResult;
        }

        /// <summary>
        /// 货车路径规划
        /// </summary>
        /// <param name="planParam">规划路径参数</param>
        /// <returns>路径规划结果</returns>
        public string TruckOriginalPlanning(TruckPlanParam planParam)
        {
            string getUrl = "https://restapi.amap.com/v4/direction/truck?{0}";
            string paras = planParam.GenerateParams();
            getUrl = string.Format(getUrl, paras);
            string planResult = WebRequestHelper.HttpGet(getUrl);
            return planResult;
        }

        /// <summary>
        /// 货车路径规划
        /// </summary>
        /// <param name="planParam">规划路径参数</param>
        /// <returns>路径规划结果</returns>
        public TruckPlanResult TruckPlanning(TruckPlanParam planParam)
        {
            planParam.output = "JSON";
            string jsonResult = TruckOriginalPlanning(planParam);
            if (!string.IsNullOrWhiteSpace(jsonResult))
            {
                jsonResult = jsonResult.Replace("[]", "\"\"");
            }
            TruckPlanResult planResult = JsonConvert.DeserializeObject<TruckPlanResult>(jsonResult);
            return planResult;
        }

        /// <summary>
        /// 距离测量
        /// </summary>
        /// <param name="distanceParam">距离测量参数</param>
        /// <returns>距离测量结果</returns>
        public string DistanceOriginalMeasure(DistanceParam distanceParam)
        {
            string getUrl = "https://restapi.amap.com/v3/distance?{0}";
            string paras = distanceParam.GenerateParams();
            getUrl = string.Format(getUrl, paras);
            string distanceResult = WebRequestHelper.HttpGet(getUrl);
            return distanceResult;
        }

        /// <summary>
        /// 距离测量
        /// </summary>
        /// <param name="distanceParam">距离测量参数</param>
        /// <returns>距离测量结果</returns>
        public DistanceResult DistanceMeasure(DistanceParam distanceParam)
        {
            distanceParam.output = "JSON";
            string jsonResult = DistanceOriginalMeasure(distanceParam);
            if (!string.IsNullOrWhiteSpace(jsonResult))
            {
                jsonResult = jsonResult.Replace("[]", "\"\"");
            }
            DistanceResult distanceResult = JsonConvert.DeserializeObject<DistanceResult>(jsonResult);
            return distanceResult;
        }
    }
}
