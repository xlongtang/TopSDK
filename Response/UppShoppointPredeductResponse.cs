using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// UppShoppointPredeductResponse.
    /// </summary>
    public class UppShoppointPredeductResponse : TopResponse
    {
        /// <summary>
        /// 是否调用成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 用于实际扣减的时候关联系统扣减记录,需要调用方保存。
        /// </summary>
        [XmlElement("transaction_id")]
        public long TransactionId { get; set; }
    }
}
