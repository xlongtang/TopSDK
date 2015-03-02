using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// FenxiaoDealerRequisitionorderCreateResponse.
    /// </summary>
    public class FenxiaoDealerRequisitionorderCreateResponse : TopResponse
    {
        /// <summary>
        /// 经销采购申请编号
        /// </summary>
        [XmlElement("dealer_order_id")]
        public long DealerOrderId { get; set; }
    }
}
