using NugetLibs.GaoDeMap.HelpModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.WebService
{
    /// <summary>
    /// 地图坐标数据处理服务的接口声明
    /// </summary>
    public interface ICoordinateService
    {
        /// <summary>
        /// 转换坐标获取原响应字符内容
        /// </summary>
        /// <param name="queryParam">查询参数</param>
        /// <returns>转换的坐标原字符内容</returns>
        string ConvertOriginalVal(CoordinateParam queryParam);

        /// <summary>
        /// 转换坐标获取转换后结果
        /// </summary>
        /// <param name="queryParam"></param>
        /// <returns>转换的坐标结果</returns>
        CoordinateResult ConvertVal(CoordinateParam queryParam);
    }
}
