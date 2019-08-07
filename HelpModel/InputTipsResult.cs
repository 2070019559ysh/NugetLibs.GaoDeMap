using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.HelpModel
{
    /// <summary>
    /// 输入提示响应结果
    /// </summary>
    public class InputTipsResult : GaoDeBaseResult
    {
        /// <summary>
        /// 返回结果总数目
        /// </summary>
        public int count;
        /// <summary>
        /// 建议提示列表
        /// </summary>
        public List<TipInfo> tips;
    }

    /// <summary>
    /// 提示信息
    /// </summary>
    public class TipInfo
    {
        /// <summary>
        /// 返回数据ID
        /// <para>若数据为POI类型，则返回POI ID;若数据为bus类型，则返回bus id;若数据为busline类型，则返回busline id</para>
        /// </summary>
        public string id;
        /// <summary>
        /// tip名称
        /// </summary>
        public string name;
        /// <summary>
        /// 所属区域
        /// <para>省+市+区（直辖市为“市+区”）</para>
        /// </summary>
        public string district;
        /// <summary>
        /// 六位区县编码
        /// </summary>
        public string adcode;
        /// <summary>
        /// tip中心点坐标
        /// <para>当搜索数据为busline类型时，此字段不返回</para>
        /// </summary>
        public string location;
        /// <summary>
        /// 详细地址
        /// </summary>
        public string address;
    }
}
