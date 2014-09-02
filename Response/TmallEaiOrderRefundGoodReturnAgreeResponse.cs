using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallEaiOrderRefundGoodReturnAgreeResponse.
    /// </summary>
    public class TmallEaiOrderRefundGoodReturnAgreeResponse : TopResponse
    {
        /// <summary>
        /// 操作结果
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
