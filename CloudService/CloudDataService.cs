using Newtonsoft.Json;
using NugetLibs.GaoDeMap.CloudModel;
using NugetLibs.HelpTool;
using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.CloudService
{
    /// <summary>
    /// 云图数据处理服务类
    /// </summary>
    public class CloudDataService : ICloudDataService
    {
        /// <summary>
        /// 创建云图表，返回原字符串
        /// </summary>
        /// <param name="name">云图表名称</param>
        /// <returns>创建云图表结果字符串</returns>
        public string CreateTableOriginal(string name)
        {
            string queryString = QueryHelper.QueryStringSort("key=" + GaoDeConfig.AppKey + "&name=" + name);
            string result = WebRequestHelper.FormPostHttp("https://yuntuapi.amap.com/datamanage/table/create", new Dictionary<string,string>
            {
                { "key", GaoDeConfig.AppKey },
                { "name", name },
                { "sig", EncryptHelper.HashMD5(queryString + GaoDeConfig.SignSecret) }
            });
            return result;
        }

        /// <summary>
        /// 创建云图表
        /// </summary>
        /// <param name="name">云图表名称</param>
        /// <returns>创建云图表结果对象</returns>
        public CloudTableResult CreateTable(string name)
        {
            string queryString = QueryHelper.QueryStringSort("key=" + GaoDeConfig.AppKey + "&name=" + name);
            CloudTableResult result = WebRequestHelper.FormPostHttp<CloudTableResult>("https://yuntuapi.amap.com/datamanage/table/create",
                new Dictionary<string, string>
                {
                    { "key", GaoDeConfig.AppKey },
                    { "name", name },
                    { "sig", EncryptHelper.HashMD5(queryString + GaoDeConfig.SignSecret) }
                });
            return result;
        }

        /// <summary>
        /// 创建单条云图数据
        /// </summary>
        /// <param name="singleData">单条云图数据</param>
        /// <returns>创建单条数据结果对象</returns>
        public CloudDataResult CreateData(SingleDataParam singleData)
        {
            Dictionary<string,string> postData = singleData.GenerateParams();
            CloudDataResult result = WebRequestHelper.FormPostHttp<CloudDataResult>("https://yuntuapi.amap.com/datamanage/data/create",
               postData);
            return result;
        }

        /// <summary>
        /// 批量创建云图数据
        /// </summary>
        /// <param name="fileName">文件名，如：cloudmap.xlsx</param>
        /// <param name="batchData">云图数据批量参数</param>
        /// <returns>批量创建任务结果</returns>
        public CloudBatchDataResult CreateBatchData(string fileName, BatchDataParam batchData)
        {
            UploadFileParam uploadFileParam = new UploadFileParam("https://yuntuapi.amap.com/datamanage/data/batchcreate",
                fileName, batchData.file);
            uploadFileParam.FileNameKey = "file";
            uploadFileParam.PostParameters = batchData.GenerateParams();
            string resultStr = WebRequestHelper.UploadFile(uploadFileParam);
            CloudBatchDataResult resultObj = JsonConvert.DeserializeObject<CloudBatchDataResult>(resultStr);
            return resultObj;
        }
    }
}
