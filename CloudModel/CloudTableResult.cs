using NugetLibs.GaoDeMap.HelpModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.CloudModel
{
    /// <summary>
    /// 云图创建结果
    /// </summary>
    public class CloudTableResult : GaoDeBaseResult
    {
        /// <summary>
        /// 生成的数据表的唯一标识
        /// </summary>
        public string tableid;
    }

    /// <summary>
    /// 云图单数据创建结果
    /// </summary>
    public class CloudDataResult : GaoDeBaseResult
    {
        /// <summary>
        /// 成功创建的数据id
        /// </summary>
        public string _id;
    }

    /// <summary>
    /// 云图批量数据任务创建结果
    /// </summary>
    public class CloudBatchDataResult : GaoDeBaseResult
    {
        /// <summary>
        /// 本次批处理任务的唯一标识
        /// <para>若批量处理任务创建成功，则返回该任务的唯一标识batchid</para>
        /// </summary>
        public string batchid;
    }
}
