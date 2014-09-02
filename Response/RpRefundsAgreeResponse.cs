using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// RpRefundsAgreeResponse.
    /// </summary>
    public class RpRefundsAgreeResponse : TopResponse
    {
        /// <summary>
        /// 同意退款操作返回信息
        /// </summary>
        [XmlElement("response")]
        public RefundAgreeResponse Response { get; set; }
    }
}
