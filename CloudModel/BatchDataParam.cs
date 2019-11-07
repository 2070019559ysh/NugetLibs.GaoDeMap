using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NugetLibs.GaoDeMap.CloudModel
{
    /// <summary>
    /// 批量创建云图数据参数
    /// </summary>
    public class BatchDataParam : CloudBaseParam
    {
        /// <summary>
        /// 数据表唯一标识，必填
        /// </summary>
        public string tableid;
        /// <summary>
        /// 上传文件的流，必填
        /// </summary>
        public Stream file;
        /// <summary>
        /// 文件中代表“名称”的字段，必填
        /// </summary>
        public string _name;
        /// <summary>
        /// 定位方式，可选
        /// <para>设置是以请求中的经纬度参数（_location）还是地址参数（_address）来计算最终的坐标值。</para>
        /// <para>可选值：1：经纬度；格式示例：104.394729,31.125698</para>
        /// <para>2：地址；标准格式示例：北京市朝阳区望京阜通东大街6号院3号楼</para>
        /// </summary>
        public int loctype = 1;
        /// <summary>
        /// 文件中代表”地址”的字段
        /// <para>当loctype=2时，必填</para>
        /// </summary>
        public string _address;
        /// <summary>
        /// 文件中代表”经度”（格式示例：104.394729）的字段
        /// <para>当loctype=1时，必填</para>
        /// </summary>
        public string longitude;
        /// <summary>
        /// 文件中代表”纬度”（格式示例：31.125698）的字段
        /// <para>当loctype=1时，必填</para>
        /// </summary>
        public string latitude;
        /// <summary>
        /// 坐标类型
        /// <para>可选，仅当定位方式loctype=1时，该字段有效</para>
        /// <para>可选值：1: gps  2: autonavi  3: baidu</para>
        /// <para>您可输入coordtype = 1，或者autonavi</para>
        /// </summary>
        public string coordtype= "autonavi";
    }
}
