using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallWangwangfenliuConfigQueryResponse.
    /// </summary>
    public class TmallWangwangfenliuConfigQueryResponse : TopResponse
    {
        /// <summary>
        /// 返回商家的配置
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }
    }
}
