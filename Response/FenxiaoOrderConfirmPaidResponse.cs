using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// FenxiaoOrderConfirmPaidResponse.
    /// </summary>
    public class FenxiaoOrderConfirmPaidResponse : TopResponse
    {
        /// <summary>
        /// 确认结果成功与否
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
