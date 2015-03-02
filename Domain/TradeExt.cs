using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TradeExt Data Structure.
    /// </summary>
    [Serializable]
    public class TradeExt : TopObject
    {
        /// <summary>
        /// 关闭订单前扩展标识位
        /// </summary>
        [XmlElement("before_close_flag")]
        public long BeforeCloseFlag { get; set; }

        /// <summary>
        /// 确认收货前扩展标识位
        /// </summary>
        [XmlElement("before_confirm_flag")]
        public long BeforeConfirmFlag { get; set; }

        /// <summary>
        /// enable前扩展标识位
        /// </summary>
        [XmlElement("before_enable_flag")]
        public long BeforeEnableFlag { get; set; }

        /// <summary>
        /// 修改前扩展标识位
        /// </summary>
        [XmlElement("before_modify_flag")]
        public long BeforeModifyFlag { get; set; }

        /// <summary>
        /// 付款前扩展标识位
        /// </summary>
        [XmlElement("before_pay_flag")]
        public long BeforePayFlag { get; set; }

        /// <summary>
        /// 评价前扩展标识位
        /// </summary>
        [XmlElement("before_rate_flag")]
        public long BeforeRateFlag { get; set; }

        /// <summary>
        /// 退款前扩展标识位
        /// </summary>
        [XmlElement("before_refund_flag")]
        public long BeforeRefundFlag { get; set; }

        /// <summary>
        /// 发货前扩展标识位
        /// </summary>
        [XmlElement("before_ship_flag")]
        public long BeforeShipFlag { get; set; }

        /// <summary>
        /// attributes标记
        /// </summary>
        [XmlElement("ext_attributes")]
        public string ExtAttributes { get; set; }

        /// <summary>
        /// 第三方个性化数据
        /// </summary>
        [XmlElement("extra_data")]
        public string ExtraData { get; set; }

        /// <summary>
        /// 第三方状态，第三方自由定义
        /// </summary>
        [XmlElement("third_party_status")]
        public long ThirdPartyStatus { get; set; }
    }
}
