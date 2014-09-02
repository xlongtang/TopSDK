using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// HanoiFunctionExecuteResponse.
    /// </summary>
    public class HanoiFunctionExecuteResponse : TopResponse
    {
        /// <summary>
        /// function执行结果。根据action不同而不同。使用SimpleResult封装，target通常为true或false
        /// </summary>
        [XmlElement("model")]
        public string Model { get; set; }
    }
}
