using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallEaiOrderRefundOrderHoldResponse.
    /// </summary>
    public class TmallEaiOrderRefundOrderHoldResponse : TopResponse
    {
        /// <summary>
        /// 操作结果
        /// </summary>
        [XmlElement("is_success")]
        public string IsSuccess { get; set; }
    }
}
