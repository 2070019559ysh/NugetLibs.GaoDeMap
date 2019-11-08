using Newtonsoft.Json;
using NugetLibs.GaoDeMap.CloudModel;
using NugetLibs.GaoDeMap.HelpModel;
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
        /// <param name="key">高德Key</param>
        /// <param name="secret">高德密钥</param>
        /// <returns>创建云图表结果字符串</returns>
        public string CreateTableOriginal(string name, string key = null, string secret = null)
        {
            if (string.IsNullOrWhiteSpace(key))
                key = GaoDeConfig.AppKey;
            if (string.IsNullOrWhiteSpace(secret))
                secret = GaoDeConfig.SignSecret;
            string queryString = QueryHelper.QueryStringSort("key=" + key + "&name=" + name);
            string result = WebRequestHelper.FormPostHttp("https://yuntuapi.amap.com/datamanage/table/create", new Dictionary<string, string>
            {
                { "key", key  },
                { "name", name },
                { "sig", EncryptHelper.HashMD5(queryString + secret) }
            });
            return result;
        }

        /// <summary>
        /// 创建云图表
        /// </summary>
        /// <param name="name">云图表名称</param>
        /// <param name="key">高德Key</param>
        /// <param name="secret">高德密钥</param>
        /// <returns>创建云图表结果对象</returns>
        public CloudTableResult CreateTable(string name, string key = null, string secret = null)
        {
            if (string.IsNullOrWhiteSpace(key))
                key = GaoDeConfig.AppKey;
            if (string.IsNullOrWhiteSpace(secret))
                secret = GaoDeConfig.SignSecret;
            string queryString = QueryHelper.QueryStringSort("key=" + key + "&name=" + name);
            CloudTableResult result = WebRequestHelper.FormPostHttp<CloudTableResult>("https://yuntuapi.amap.com/datamanage/table/create",
                new Dictionary<string, string>
                {
                    { "key", key },
                    { "name", name },
                    { "sig", EncryptHelper.HashMD5(queryString + secret) }
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
            if (singleData == null) throw new ArgumentNullException("singleData");
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
            if (batchData == null) throw new ArgumentNullException("batchData");
            UploadFileParam uploadFileParam = new UploadFileParam("https://yuntuapi.amap.com/datamanage/data/batchcreate",
                fileName, batchData.file);
            uploadFileParam.FileNameKey = "file";
            uploadFileParam.PostParameters = batchData.GenerateParams();
            string resultStr = WebRequestHelper.UploadFile(uploadFileParam);
            CloudBatchDataResult resultObj = JsonConvert.DeserializeObject<CloudBatchDataResult>(resultStr);
            return resultObj;
        }

        /// <summary>
        /// 更新单条云图数据
        /// </summary>
        /// <param name="singleData">单条云图数据</param>
        /// <returns>更新单条数据结果对象</returns>
        public GaoDeBaseResult UpdateData(SingleDataParam singleData)
        {
            if (singleData == null) throw new ArgumentNullException("singleData");
            Dictionary<string, string> postData = singleData.GenerateParams();
            GaoDeBaseResult result = WebRequestHelper.FormPostHttp<GaoDeBaseResult>("https://yuntuapi.amap.com/datamanage/data/update",
               postData);
            return result;
        }

        /// <summary>
        /// 删除单条或批量的云图数据
        /// </summary>
        /// <param name="delData">删除的云图数据</param>
        /// <returns>删除云图数据结果对象</returns>
        public DelDataResult DeleteData(DelDataParam delData)
        {
            if (delData == null) throw new ArgumentNullException("delData");
            Dictionary<string, string> postData = delData.GenerateParams();
            DelDataResult result = WebRequestHelper.FormPostHttp<DelDataResult>("https://yuntuapi.amap.com/datamanage/data/delete",
               postData);
            return result;
        }

        /// <summary>
        /// 批量创建云图数据的进度查询 
        /// </summary>
        /// <param name="queryParam">查询参数</param>
        /// <returns>进度查询 结果</returns>
        public BatchSearchResult SearchBatchProgress(BatchSearchParam queryParam)
        {
            string getUrl = "https://yuntuapi.amap.com/datamanage/batch/importstatus?{0}";
            string paras = queryParam.GenerateParam();
            getUrl = string.Format(getUrl, paras);
            string queryResult = WebRequestHelper.HttpGet(getUrl);
            if (!string.IsNullOrWhiteSpace(queryResult))
            {
                queryResult = queryResult.Replace("[]", "\"\"");
            }
            BatchSearchResult resultObj = JsonConvert.DeserializeObject<BatchSearchResult>(queryResult);
            return resultObj;
        }
    }
}
