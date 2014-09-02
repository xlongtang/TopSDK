using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// IncrementCustomerStopResponse.
    /// </summary>
    public class IncrementCustomerStopResponse : TopResponse
    {
        /// <summary>
        /// 关闭增量消息或数据同步是否成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
