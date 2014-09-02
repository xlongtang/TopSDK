using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// WlbExtOrder Data Structure.
    /// </summary>
    [Serializable]
    public class WlbExtOrder : TopObject
    {
        /// <summary>
        /// 买家id
        /// </summary>
        [XmlElement("buyer_id")]
        public long BuyerId { get; set; }

        /// <summary>
        /// 买家nick
        /// </summary>
        [XmlElement("buyer_nick")]
        public string BuyerNick { get; set; }

        /// <summary>
        /// 订单来源：  TAOBAO  PAIPAI
        /// </summary>
        [XmlElement("ext_order_source")]
        public string ExtOrderSource { get; set; }

        /// <summary>
        /// 订单已创建：CREATE  订单下发中：PROCESSING  订单接受成功：ACCESSED  订单关闭：CLOSED
        /// </summary>
        [XmlElement("ext_order_status")]
        public string ExtOrderStatus { get; set; }

        /// <summary>
        /// 订单状态原因
        /// </summary>
        [XmlElement("ext_order_status_reason")]
        public string ExtOrderStatusReason { get; set; }

        /// <summary>
        /// 订单标识号
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// SALE:销售订单  SALE_RETURN:销售退货单
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 取消前订单
        /// </summary>
        [XmlElement("prev_id")]
        public string PrevId { get; set; }

        /// <summary>
        /// 收件人地址
        /// </summary>
        [XmlElement("receiver_address")]
        public string ReceiverAddress { get; set; }

        /// <summary>
        /// 国家地区标准编码
        /// </summary>
        [XmlElement("receiver_country_id")]
        public string ReceiverCountryId { get; set; }

        /// <summary>
        /// 收件人email
        /// </summary>
        [XmlElement("receiver_mail")]
        public string ReceiverMail { get; set; }

        /// <summary>
        /// 收件人手机
        /// </summary>
        [XmlElement("receiver_mobile")]
        public string ReceiverMobile { get; set; }

        /// <summary>
        /// 收件人姓名
        /// </summary>
        [XmlElement("receiver_name")]
        public string ReceiverName { get; set; }

        /// <summary>
        /// 收件人固话
        /// </summary>
        [XmlElement("receiver_phone")]
        public string ReceiverPhone { get; set; }

        /// <summary>
        /// 收件人旺旺
        /// </summary>
        [XmlElement("receiver_wangwang")]
        public string ReceiverWangwang { get; set; }

        /// <summary>
        /// 收件人邮编
        /// </summary>
        [XmlElement("receiver_zip")]
        public string ReceiverZip { get; set; }

        /// <summary>
        /// 订单备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 卖家id
        /// </summary>
        [XmlElement("seller_id")]
        public long SellerId { get; set; }

        /// <summary>
        /// 卖家nick
        /// </summary>
        [XmlElement("seller_nick")]
        public string SellerNick { get; set; }

        /// <summary>
        /// 发货人姓名
        /// </summary>
        [XmlElement("send_name")]
        public string SendName { get; set; }

        /// <summary>
        /// 物流运送方式
        /// </summary>
        [XmlElement("shipping_type")]
        public string ShippingType { get; set; }

        /// <summary>
        /// 快递公司编码
        /// </summary>
        [XmlElement("tms_code")]
        public string TmsCode { get; set; }

        /// <summary>
        /// 订单总价
        /// </summary>
        [XmlElement("total_price")]
        public long TotalPrice { get; set; }

        /// <summary>
        /// 发货仓库编码
        /// </summary>
        [XmlElement("wms_code")]
        public string WmsCode { get; set; }
    }
}
