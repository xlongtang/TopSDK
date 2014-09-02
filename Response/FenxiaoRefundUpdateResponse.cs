using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// FenxiaoRefundUpdateResponse.
    /// </summary>
    public class FenxiaoRefundUpdateResponse : TopResponse
    {
        /// <summary>
        /// 退款是否修改成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
