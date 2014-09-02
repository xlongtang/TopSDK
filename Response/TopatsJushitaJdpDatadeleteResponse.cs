using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TopatsJushitaJdpDatadeleteResponse.
    /// </summary>
    public class TopatsJushitaJdpDatadeleteResponse : TopResponse
    {
        /// <summary>
        /// 创建任务信息。里面只包含task_id和created
        /// </summary>
        [XmlElement("task")]
        public Task Task { get; set; }
    }
}
