using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallEaiOrderRefundAgreeResponse.
    /// </summary>
    public class TmallEaiOrderRefundAgreeResponse : TopResponse
    {
        /// <summary>
        /// 操作结果编码
        /// </summary>
        [XmlElement("code")]
        public long Code { get; set; }

        /// <summary>
        /// 接口调用结果
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 同意退款结果
        /// </summary>
        [XmlArray("result_list")]
        [XmlArrayItem("refund_agree_result")]
        public List<RefundAgreeResult> ResultList { get; set; }
    }
}
