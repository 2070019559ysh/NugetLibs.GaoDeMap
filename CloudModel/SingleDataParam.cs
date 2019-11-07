using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.CloudModel
{
    /// <summary>
    /// 云图创建单条数据参数
    /// </summary>
    public class SingleDataParam : CloudBaseParam
    {
        /// <summary>
        /// 数据表唯一标识，必填
        /// </summary>
        public string tableid;
        /// <summary>
        /// 定位方式，可选
        /// <para>设置是以请求中的经纬度参数（_location）还是地址参数（_address）来计算最终的坐标值。</para>
        /// <para>可选值：1：经纬度；格式示例：104.394729,31.125698</para>
        /// <para>2：地址；标准格式示例：北京市朝阳区望京阜通东大街6号院3号楼</para>
        /// </summary>
        public int loctype = 1;
        /// <summary>
        /// 新增的数据，必填
        /// </summary>
        public CloudDataInfo data;
    }

    /// <summary>
    /// 云图坐标数据
    /// </summary>
    public class CloudDataInfo
    {
        /// <summary>
        /// 数据id，修改时必填
        /// </summary>
        public string _id;
        /// <summary>
        /// 数据名称，必填
        /// </summary>
        public string _name;
        /// <summary>
        /// 坐标，当loctype=1时，必填
        /// <para>规则：经度,纬度，经纬度支持到小数点后6位</para>
        /// </summary>
        public string _location;
        /// <summary>
        /// 坐标类型，可选
        /// <para>可选值：1: gps  2: autonavi  3: baidu</para>
        /// <para>您可输入coordtype = 1，或者autonavi</para>
        /// </summary>
        public string coordtype = "autonavi";
        /// <summary>
        /// 地址，当loctype=2时，必填
        /// </summary>
        public string _address;
        /// <summary>
        /// 用户自定义字段1
        /// </summary>
        //public string customfield1;
        /// <summary>
        /// 用户自定义字段2
        /// </summary>
        //public string customfield2;
        /// <summary>
        /// 用户自定义字段3
        /// </summary>
        //public string customfield3;
    }
}
