using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TopatsResultGetResponse.
    /// </summary>
    public class TopatsResultGetResponse : TopResponse
    {
        /// <summary>
        /// 任务结果信息
        /// </summary>
        [XmlElement("task")]
        public Task Task { get; set; }
    }
}
