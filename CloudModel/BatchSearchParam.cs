using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.CloudModel
{
    /// <summary>
    /// 批量创建云图数据的进度查询参数
    /// </summary>
    public class BatchSearchParam : CloudBaseParam
    {
        /// <summary>
        /// 数据表唯一标识，必填
        /// </summary>
        public string tableid;
        /// <summary>
        /// 批量处理任务唯一标识，必填
        /// </summary>
        public string batchid;
    }
}
