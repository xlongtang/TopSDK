using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// UmpToolUpdateResponse.
    /// </summary>
    public class UmpToolUpdateResponse : TopResponse
    {
        /// <summary>
        /// 更新后生成的新的工具id
        /// </summary>
        [XmlElement("tool_id")]
        public long ToolId { get; set; }
    }
}
