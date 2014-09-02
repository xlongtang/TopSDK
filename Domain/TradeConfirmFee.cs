using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TradeConfirmFee Data Structure.
    /// </summary>
    [Serializable]
    public class TradeConfirmFee : TopObject
    {
        /// <summary>
        /// 确认收货的金额(不包含邮费)。精确到2位小数;单位:元。如:200.07，表示:200元7分
        /// </summary>
        [XmlElement("confirm_fee")]
        public string ConfirmFee { get; set; }

        /// <summary>
        /// 需确认收货的邮费，当不是最后一笔收货或者没有邮费时是0.00。精确到2位小数;单位:元。如:200.07，表示:200元7分
        /// </summary>
        [XmlElement("confirm_post_fee")]
        public string ConfirmPostFee { get; set; }

        /// <summary>
        /// 是否是最后一笔订单（只对子订单有效，当其他子订单都是交易完成时，返回true，否则false）
        /// </summary>
        [XmlElement("is_last_order")]
        public bool IsLastOrder { get; set; }
    }
}
