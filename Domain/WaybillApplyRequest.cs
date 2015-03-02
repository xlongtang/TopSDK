using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// WaybillApplyRequest Data Structure.
    /// </summary>
    [Serializable]
    public class WaybillApplyRequest : TopObject
    {
        /// <summary>
        /// TOP平台请求的ISV APPKEY
        /// </summary>
        [XmlElement("app_key")]
        public string AppKey { get; set; }

        /// <summary>
        /// 物流服务商ID
        /// </summary>
        [XmlElement("cp_code")]
        public string CpCode { get; set; }

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
    }
}
