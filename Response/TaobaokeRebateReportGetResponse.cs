using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TaobaokeRebateReportGetResponse.
    /// </summary>
    public class TaobaokeRebateReportGetResponse : TopResponse
    {
        /// <summary>
        /// 淘宝客订单
        /// </summary>
        [XmlArray("taobaoke_payments")]
        [XmlArrayItem("taobaoke_payment")]
        public List<TaobaokePayment> TaobaokePayments { get; set; }
    }
}
