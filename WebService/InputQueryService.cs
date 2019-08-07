using Newtonsoft.Json;
using NugetLibs.GaoDeMap.HelpModel;
using NugetLibs.HelpTool;
using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.WebService
{
    /// <summary>
    /// 输入关键字数据查询处理
    /// </summary>
    public class InputQueryService : IInputQueryService
    {
        /// <summary>
        /// 查询输入提示数据
        /// </summary>
        /// <param name="queryParam">查询参数</param>
        /// <returns>输入提示数据</returns>
        public string SearchOriginalInputTips(InputTipsParam queryParam)
        {
            string getUrl = GaoDeConst.WebAPIHost + "/v3/assistant/inputtips?{0}";
            string paras = queryParam.GenerateParams();
            getUrl = string.Format(getUrl, paras);
            string queryResult = WebRequestHelper.HttpGet(getUrl);
            return queryResult;
        }

        /// <summary>
        /// 查询输入提示数据
        /// </summary>
        /// <param name="queryParam">查询参数</param>
        /// <returns>输入提示数据</returns>
        public InputTipsResult SearchInputTips(InputTipsParam queryParam)
        {
            queryParam.output = "JSON";
            string jsonResult = SearchOriginalInputTips(queryParam);
            if (!string.IsNullOrWhiteSpace(jsonResult))
            {
                jsonResult = jsonResult.Replace("[]", "\"\"");
            }
            InputTipsResult queryResult = JsonConvert.DeserializeObject<InputTipsResult>(jsonResult);
            return queryResult;
        }
    }
}
