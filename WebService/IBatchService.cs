using NugetLibs.GaoDeMap.HelpModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.WebService
{
    /// <summary>
    /// 批量请求接口处理服务接口声明
    /// </summary>
    public interface IBatchService
    {
        /// <summary>
        /// 批量请求接口
        /// </summary>
        /// <param name="webApi">需请求的webApi</param>
        /// <param name="apiParam">请求接口对应的参数</param>
        /// <returns>批量接口结果</returns>
        string RequestAllOrigin(string[] webApi, params GaoDeBaseParam[] apiParam);

        /// <summary>
        /// 批量请求接口
        /// </summary>
        /// <param name="webApi">需请求的webApi</param>
        /// <param name="apiParam">请求接口对应的参数</param>
        /// <returns>批量接口结果</returns>
        List<BatchApiResult> RequestAll(string[] webApi, params GaoDeBaseParam[] apiParam);
    }
}
