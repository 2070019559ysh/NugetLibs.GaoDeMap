using Newtonsoft.Json;
using NugetLibs.GaoDeMap.HelpModel;
using NugetLibs.HelpTool;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace NugetLibs.GaoDeMap.WebService
{
    /// <summary>
    /// 批量请求接口处理服务
    /// </summary>
    public class BatchService : IBatchService
    {
        /// <summary>
        /// 批量请求接口（当前支持所有v3接口）
        /// </summary>
        /// <param name="webApi">需请求的webApi</param>
        /// <param name="apiParam">请求接口对应的参数</param>
        /// <returns>批量接口结果</returns>
        public string RequestAllOrigin(string[] webApi,params GaoDeBaseParam[] apiParam)
        {
            Contract.Requires<GaoDeException>(webApi != null && webApi.Length >= 1, "请求接口必须指定");
            Contract.Requires<GaoDeException>(apiParam != null && webApi.Length <= apiParam.Length, "接口参数不足");
            var requestData = new { ops = new ArrayList() };
            string apiKey = string.Empty;
            for(int i = 0; i < webApi.Length; i++)
            {
                if (i == 0) apiKey = apiParam[i].key;
                string paras = apiParam[i].GenerateParams();
                string getUrl = webApi[i] + "?" + paras;
                requestData.ops.Add(new { url = getUrl });
            }
            string result = WebRequestHelper.PostHttp(GaoDeConst.WebAPIHost + "/v3/batch?key=" + apiKey, requestData);
            return result;
        }

        /// <summary>
        /// 批量请求接口（当前支持所有v3接口）
        /// </summary>
        /// <param name="webApi">需请求的webApi</param>
        /// <param name="apiParam">请求接口对应的参数</param>
        /// <returns>批量接口结果</returns>
        public List<BatchApiResult> RequestAll(string[] webApi, params GaoDeBaseParam[] apiParam)
        {
            if(apiParam!=null)
                foreach(var myParam in apiParam)
                {
                    myParam.output = "JSON";
                }
            string jsonResult = RequestAllOrigin(webApi, apiParam);
            if (!string.IsNullOrWhiteSpace(jsonResult))
            {
                jsonResult = jsonResult.Replace("[]", "\"\"").Replace("{}", "\"\"");
            }
            List<BatchApiResult> resultList = JsonConvert.DeserializeObject<List<BatchApiResult>>(jsonResult);
            return resultList;
        }
    }
}
