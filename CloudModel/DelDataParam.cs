using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.CloudModel
{
    /// <summary>
    /// 删除云图数据参数
    /// </summary>
    public class DelDataParam : CloudBaseParam
    {
        /// <summary>
        /// 数据表唯一标识，必填
        /// </summary>
        public string tableid;
        /// <summary>
        /// 删除的数据_id，必填
        /// <para>一次请求限制1-50条数据，多个_id用逗号隔开</para>
        /// </summary>
        public string ids;
    }
}
