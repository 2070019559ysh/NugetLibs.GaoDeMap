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
        /// <para>每个batchid的有效期为：处理结束后1小时内</para>
        /// </summary>
        public string batchid;
    }

    /// <summary>
    /// 删除云图数据结果
    /// </summary>
    public class DelDataResult : GaoDeBaseResult
    {
        /// <summary>
        /// 删除成功数目，非负整数
        /// </summary>
        public int success;
        /// <summary>
        /// 删除失败数目，非负整数
        /// </summary>
        public int fail;
    }

    /// <summary>
    /// 批量创建云图数据的任务处理进度结果
    /// </summary>
    public class BatchSearchResult : GaoDeBaseResult
    {
        /// <summary>
        /// 处理进度
        /// 取值范围[0,100]
        /// </summary>
        public int progress;
        /// <summary>
        /// 已导入的数据数目
        /// </summary>
        public int imported;
        /// <summary>
        /// 定位准确数目
        /// </summary>
        public int locaccurate;
        /// <summary>
        /// 定位可能偏差数目
        /// </summary>
        public int locinaccurate;
        /// <summary>
        /// 定位失败数目
        /// </summary>
        public int locfail;
    }
}
