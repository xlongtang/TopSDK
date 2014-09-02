using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TradeTrace Data Structure.
    /// </summary>
    [Serializable]
    public class TradeTrace : TopObject
    {
        /// <summary>
        /// 动作发生的时间
        /// </summary>
        [XmlElement("action_time")]
        public string ActionTime { get; set; }

        /// <summary>
        /// 应用标题
        /// </summary>
        [XmlElement("app_title")]
        public string AppTitle { get; set; }

        /// <summary>
        /// 子订单的id列表,以逗号分割
        /// </summary>
        [XmlElement("order_ids")]
        public string OrderIds { get; set; }

        /// <summary>
        /// 备注字段
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 卖家的淘宝nick
        /// </summary>
        [XmlElement("seller_nick")]
        public string SellerNick { get; set; }

        /// <summary>
        /// 回流的订单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 交易tid
        /// </summary>
        [XmlElement("tid")]
        public long Tid { get; set; }
    }
}
