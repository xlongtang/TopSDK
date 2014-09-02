using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// UppShoppointPresendResponse.
    /// </summary>
    public class UppShoppointPresendResponse : TopResponse
    {
        /// <summary>
        /// 是否调用成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 用于实际发放的时候关联系统发放记录,需要调用方保存
        /// </summary>
        [XmlElement("transaction_id")]
        public long TransactionId { get; set; }
    }
}
