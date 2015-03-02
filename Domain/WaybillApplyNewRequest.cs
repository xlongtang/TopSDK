using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// WaybillApplyNewRequest Data Structure.
    /// </summary>
    [Serializable]
    public class WaybillApplyNewRequest : TopObject
    {
        /// <summary>
        /// TOP  appkey
        /// </summary>
        [XmlElement("app_key")]
        public string AppKey { get; set; }

        /// <summary>
        /// 物流服务商编码
        /// </summary>
        [XmlElement("cp_code")]
        public string CpCode { get; set; }

        /// <summary>
        /// --
        /// </summary>
        [XmlElement("cp_id")]
        public long CpId { get; set; }

        /// <summary>
        /// 使用者ID
        /// </summary>
        [XmlElement("real_user_id")]
        public long RealUserId { get; set; }

        /// <summary>
        /// 商家ID
        /// </summary>
        [XmlElement("seller_id")]
        public long SellerId { get; set; }

        /// <summary>
        /// 发货地址
        /// </summary>
        [XmlElement("shipping_address")]
        public WaybillAddress ShippingAddress { get; set; }

        /// <summary>
        /// 面单详细信息
        /// </summary>
        [XmlElement("trade_order_info_cols")]
        public TradeOrderInfo TradeOrderInfoCols { get; set; }
    }
}
