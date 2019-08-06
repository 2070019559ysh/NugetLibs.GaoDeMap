using NugetLibs.GaoDeMap.HelpModel;
using NugetLibs.HelpTool;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NugetLibs.GaoDeMap.WebService
{
    /// <summary>
    /// 静态地图的处理服务
    /// </summary>
    public class StaticMapService : IStaticMapService
    {
        /// <summary>
        /// 获取静态地图
        /// </summary>
        /// <param name="queryParam">查询参数</param>
        /// <param name="contentType">输出图片内容类型</param>
        /// <returns>静态地图缓存流</returns>
        public MemoryStream GetOriginalMap(StaticMapParam queryParam, out string contentType)
        {
            string getUrl = GaoDeConst.WebAPIHost + "/v3/staticmap?{0}";
            string paras = queryParam.GenerateParams();
            getUrl = string.Format(getUrl, paras);
            MemoryStream queryResult = WebRequestHelper.HttpGetStream(getUrl,out contentType);
            return queryResult;
        }
    }
}
