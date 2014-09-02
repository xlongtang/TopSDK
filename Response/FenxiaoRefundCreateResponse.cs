using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// FenxiaoRefundCreateResponse.
    /// </summary>
    public class FenxiaoRefundCreateResponse : TopResponse
    {
        /// <summary>
        /// 退款是否创建成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
