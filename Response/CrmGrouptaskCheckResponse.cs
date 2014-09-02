using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// CrmGrouptaskCheckResponse.
    /// </summary>
    public class CrmGrouptaskCheckResponse : TopResponse
    {
        /// <summary>
        /// 异步任务是否完成，true表示完成
        /// </summary>
        [XmlElement("is_finished")]
        public bool IsFinished { get; set; }
    }
}
