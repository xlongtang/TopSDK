using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TopatsFenxiaoOrdersGetResponse.
    /// </summary>
    public class TopatsFenxiaoOrdersGetResponse : TopResponse
    {
        /// <summary>
        /// 返回任务处理信息
        /// </summary>
        [XmlElement("task")]
        public Task Task { get; set; }
    }
}
