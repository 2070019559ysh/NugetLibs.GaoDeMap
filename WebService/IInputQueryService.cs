using NugetLibs.GaoDeMap.HelpModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.WebService
{
    /// <summary>
    /// 输入关键字数据查询处理接口声明
    /// </summary>
    public interface IInputQueryService
    {
        /// <summary>
        /// 查询输入提示数据
        /// </summary>
        /// <param name="queryParam">查询参数</param>
        /// <returns>输入提示数据</returns>
        string SearchOriginalInputTips(InputTipsParam queryParam);

        /// <summary>
        /// 查询输入提示数据
        /// </summary>
        /// <param name="queryParam">查询参数</param>
        /// <returns>输入提示数据</returns>
        InputTipsResult SearchInputTips(InputTipsParam queryParam);
    }
}
