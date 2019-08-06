using Newtonsoft.Json;
using NugetLibs.GaoDeMap.HelpModel;
using NugetLibs.HelpTool;
using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.WebService
{
    /// <summary>
    /// 地图坐标数据处理服务
    /// </summary>
    public class CoordinateService : ICoordinateService
    {
        /// <summary>
        /// 转换坐标获取原响应字符内容
        /// </summary>
        /// <param name="queryParam">查询参数</param>
        /// <returns>转换的坐标原字符内容</returns>
        public string ConvertOriginalVal(CoordinateParam queryParam)
        {
            string getUrl = GaoDeConst.WebAPIHost + "/v3/assistant/coordinate/convert?{0}";
            string paras = queryParam.GenerateParams();
            getUrl = string.Format(getUrl, paras);
            string queryResult = WebRequestHelper.HttpGet(getUrl);
            return queryResult;
        }

        /// <summary>
        /// 转换坐标获取转换后结果
        /// </summary>
        /// <param name="queryParam"></param>
        /// <returns>转换的坐标结果</returns>
        public CoordinateResult ConvertVal(CoordinateParam queryParam)
        {
            queryParam.output = "JSON";
            string jsonResult = ConvertOriginalVal(queryParam);
            if (!string.IsNullOrWhiteSpace(jsonResult))
            {
                jsonResult = jsonResult.Replace("[]", "\"\"");
            }
            CoordinateResult queryResult = JsonConvert.DeserializeObject<CoordinateResult>(jsonResult);
            return queryResult;
        }
    }
}
