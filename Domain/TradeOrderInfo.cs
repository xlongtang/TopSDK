using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// TradeOrderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TradeOrderInfo : TopObject
    {
        /// <summary>
        /// 是否阿里系订单
        /// </summary>
        [XmlElement("ali_order")]
        public bool AliOrder { get; set; }

        /// <summary>
        /// 收货人地址
        /// </summary>
        [XmlElement("consignee_address")]
        public WaybillAddress ConsigneeAddress { get; set; }

        /// <summary>
        /// 收货人
        /// </summary>
        [XmlElement("consignee_name")]
        public string ConsigneeName { get; set; }

        /// <summary>
        /// 收货人联系方式
        /// </summary>
        [XmlElement("consignee_phone")]
        public string ConsigneePhone { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 订单渠道
        /// </summary>
        [XmlElement("order_channels_type")]
        public string OrderChannelsType { get; set; }

        /// <summary>
        /// 大头笔
        /// </summary>
        [XmlElement("short_address")]
        public string ShortAddress { get; set; }

        /// <summary>
        /// 交易订单列表
        /// </summary>
        [XmlArray("trade_order_list")]
        [XmlArrayItem("string")]
        public List<string> TradeOrderList { get; set; }

        /// <summary>
        /// 面单号
        /// </summary>
        [XmlElement("waybill_code")]
        public string WaybillCode { get; set; }
    }
}
