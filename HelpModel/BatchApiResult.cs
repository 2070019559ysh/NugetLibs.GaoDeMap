using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.HelpModel
{
    /// <summary>
    /// 批量请求接口结果
    /// </summary>
    public class BatchApiResult
    {
        /// <summary>
        /// 请求状态码，成功为200
        /// </summary>
        public int status;
        /// <summary>
        /// 接口响应结果对象
        /// </summary>
        public JObject body;
    }
}
