using NugetLibs.GaoDeMap.HelpModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.CloudModel
{
    /// <summary>
    /// 本地检索结果
    /// </summary>
    public class DataSearchResult : GaoDeBaseResult
    {
        /// <summary>
        /// 返回结果总数目
        /// </summary>
        public int count;
        /// <summary>
        /// 云图坐标数据
        /// </summary>
        public CloudDataDetail[] datas;
    }

    /// <summary>
    /// 云图坐标数据具体信息
    /// </summary>
    public class CloudDataDetail : CloudDataInfo
    {
        /// <summary>
        /// 所在省
        /// </summary>
        public string _province;
        /// <summary>
        /// 所在城市
        /// </summary>
        public string _city;
        /// <summary>
        /// 所在区
        /// </summary>
        public string _district;
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime _createtime;
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime _updatetime;
        /// <summary>
        /// 图片信息
        /// </summary>
        public CloudDataImage[] _image;
    }

    /// <summary>
    /// 云图的图片信息
    /// </summary>
    public class CloudDataImage
    {
        /// <summary>
        /// 图片id的标识
        /// </summary>
        public string _id;
        /// <summary>
        /// 经过压缩处理的图片地址
        /// <para>尺寸400*400，若期望获取体积较小的图片文件，建议使用此地址</para>
        /// </summary>
        public string _preurl;
        /// <summary>
        /// 大图片的地址
        /// <para>最大限制获取1024*1024，若您的原始图片小于该尺寸，将返回原图</para>
        /// </summary>
        public string _url;
    }

    /// <summary>
    /// 云图数据区域分布检索结果
    /// </summary>
    public class AreaSearchResult : GaoDeBaseResult
    {
        /// <summary>
        /// 云图数据区域统计
        /// </summary>
        public AreaCountInfo[] datas;
    }

    /// <summary>
    /// 区域统计信息
    /// </summary>
    public class AreaCountInfo
    {
        /// <summary>
        /// 区域名称（省、市、区县）
        /// </summary>
        public string name;
        /// <summary>
        /// POI个数
        /// </summary>
        public int count;
    }
}
