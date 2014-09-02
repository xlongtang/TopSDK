using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TakeoutShopSummaryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TakeoutShopSummaryInfo : TopObject
    {
        /// <summary>
        /// 店铺地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 等待确认的兑换券的订单笔数
        /// </summary>
        [XmlElement("digital_wait_confirm")]
        public long DigitalWaitConfirm { get; set; }

        /// <summary>
        /// 店铺营业状态，歇业：0，营业：1
        /// </summary>
        [XmlElement("is_open")]
        public long IsOpen { get; set; }

        /// <summary>
        /// 外卖店铺名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 外卖店铺id
        /// </summary>
        [XmlElement("shopid")]
        public long Shopid { get; set; }

        /// <summary>
        /// 店铺与ISV的关联ID
        /// </summary>
        [XmlElement("shopoutid")]
        public string Shopoutid { get; set; }

        /// <summary>
        /// 等待确认配送的订单笔数
        /// </summary>
        [XmlElement("wait_confirm")]
        public long WaitConfirm { get; set; }

        /// <summary>
        /// 等待退款的订单笔数
        /// </summary>
        [XmlElement("wait_refund")]
        public long WaitRefund { get; set; }
    }
}
