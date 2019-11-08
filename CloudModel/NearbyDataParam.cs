using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.CloudModel
{
    /// <summary>
    /// 云图附近上报位置的查询参数
    /// </summary>
    public class NearbyDataParam : CloudBaseParam
    {
        /// <summary>
        /// 中心点坐标，必填
        /// <para>规则： lon,lat（经度,维度），如117.500244, 40.417801 经纬度小数点不超过6位</para>
        /// </summary>
        public string center;
        /// <summary>
        /// 查询半径，可选
        /// <para>取值范围(1,10000]，单位：米，超出取值范围按照10公里返回</para>
        /// </summary>
        public int radius = 1000;
        /// <summary>
        /// 返回结果的条数，可选
        /// <para>取值范围 (1,100]</para>
        /// </summary>
        public int limit = 30;
        /// <summary>
        /// 搜索radius(半径）值代表的类型，可选
        /// <para>0：直线距离（默认），1：驾车行驶距离</para>
        /// </summary>
        public int searchtype;
        /// <summary>
        /// 检索时间范围的描述，可选
        /// <para>规则：[5,86400]，单位：秒</para>
        /// <para>可检索5s~24小时之内上传过数据的用户信息 超过24小时未上传过数据的用户将作为过期数据，无法返回</para>
        /// </summary>
        public int timerange = 1800;
    }
}
