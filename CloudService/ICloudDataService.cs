using NugetLibs.GaoDeMap.CloudModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.CloudService
{
    /// <summary>
    /// 云图数据处理服务接口声明
    /// </summary>
    public interface ICloudDataService
    {
        /// <summary>
        /// 创建云图表，返回原字符串
        /// </summary>
        /// <param name="name">云图表名称</param>
        /// <returns>创建云图表结果字符串</returns>
        string CreateTableOriginal(string name);

        /// <summary>
        /// 创建云图表
        /// </summary>
        /// <param name="name">云图表名称</param>
        /// <returns>创建云图表结果对象</returns>
        CloudTableResult CreateTable(string name);

        /// <summary>
        /// 创建单条云图数据
        /// </summary>
        /// <param name="singleData">单条云图数据</param>
        /// <returns>创建单条数据结果对象</returns>
        CloudDataResult CreateData(SingleDataParam singleData);

        /// <summary>
        /// 批量创建云图数据
        /// </summary>
        /// <param name="fileName">文件名，如：cloudmap.xlsx</param>
        /// <param name="batchData">云图数据批量参数</param>
        /// <returns>批量创建任务结果</returns>
        CloudBatchDataResult CreateBatchData(string fileName, BatchDataParam batchData);
    }
}
