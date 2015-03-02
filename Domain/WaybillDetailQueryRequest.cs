using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// WaybillDetailQueryRequest Data Structure.
    /// </summary>
    [Serializable]
    public class WaybillDetailQueryRequest : TopObject
    {
        /// <summary>
        /// TOP平台请求的ISV APPKEY
        /// </summary>
        [XmlElement("app_key")]
        public string AppKey { get; set; }

        /// <summary>
        /// CP快递公司编码
        /// </summary>
        [XmlElement("cp_code")]
        public string CpCode { get; set; }

        /// <summary>
        /// 0:根据cp_code和waybil_code查询;1:根据订单号查询
        /// </summary>
        [XmlElement("query_by")]
        public long QueryBy { get; set; }

        /// <summary>
        /// 申请者ID
        /// </summary>
        [XmlElement("seller_id")]
        public long SellerId { get; set; }

        /// <summary>
        /// 交易订单号
        /// </summary>
        [XmlArray("trade_order_list")]
        [XmlArrayItem("string")]
        public List<string> TradeOrderList { get; set; }

        /// <summary>
        /// 电子面单单号
        /// </summary>
        [XmlArray("waybill_codes")]
        [XmlArrayItem("string")]
        public List<string> WaybillCodes { get; set; }
    }
}
