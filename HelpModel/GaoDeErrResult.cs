using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.HelpModel
{
    /// <summary>
    /// 高德的含errcode的响应结果
    /// </summary>
    public class GaoDeErrResult<T>
    {
        /// <summary>
        /// 返回结果码，0，表示成功
        /// </summary>
        public int errcode;
        /// <summary>
        /// 返回结果码说明，OK代表成功
        /// </summary>
        public string errmsg;
        /// <summary>
        /// 返回数据内容消息体
        /// </summary>
        public T data;
    }
}
