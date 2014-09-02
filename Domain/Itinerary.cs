using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// Itinerary Data Structure.
    /// </summary>
    [Serializable]
    public class Itinerary : TopObject
    {
        /// <summary>
        /// 收件人地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("alipay_trade_no")]
        public string AlipayTradeNo { get; set; }

        /// <summary>
        /// 物流公司代码
        /// </summary>
        [XmlElement("company_code")]
        public string CompanyCode { get; set; }

        /// <summary>
        /// 邮寄单号
        /// </summary>
        [XmlElement("express_code")]
        public string ExpressCode { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("extra")]
        public string Extra { get; set; }

        /// <summary>
        /// 淘宝主键id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 行程单号
        /// </summary>
        [XmlElement("itinerary_no")]
        public string ItineraryNo { get; set; }

        /// <summary>
        /// 收件人手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 收件人备用手机号
        /// </summary>
        [XmlElement("mobile_bak")]
        public string MobileBak { get; set; }

        /// <summary>
        /// 收件人姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 行程单价格，单位：分
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 邮寄时间
        /// </summary>
        [XmlElement("send_date")]
        public string SendDate { get; set; }

        /// <summary>
        /// 行程单订单的状态 0：未付款 1：已付款 2：转交易成功 3：已邮寄 4：已取消
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 行程单类型：6，快递
        /// </summary>
        [XmlElement("type")]
        public long Type { get; set; }
    }
}
