using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallEaiOrderRefundGoodReturnGetResponse.
    /// </summary>
    public class TmallEaiOrderRefundGoodReturnGetResponse : TopResponse
    {
        /// <summary>
        /// 退货单
        /// </summary>
        [XmlElement("return_bill")]
        public ReturnBill ReturnBill { get; set; }
    }
}
