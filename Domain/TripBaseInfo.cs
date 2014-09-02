using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TripBaseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TripBaseInfo : TopObject
    {
        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("alipay_trade_no")]
        public string AlipayTradeNo { get; set; }

        /// <summary>
        /// 佣金，单位：分
        /// </summary>
        [XmlElement("commission")]
        public string Commission { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("extra")]
        public string Extra { get; set; }

        /// <summary>
        /// 是否强制保险订单，有一张票为强制保险即为true
        /// </summary>
        [XmlElement("force_insure")]
        public bool ForceInsure { get; set; }

        /// <summary>
        /// 是否保险分润订单，有一个乘机人支持分润即为 True
        /// </summary>
        [XmlElement("insure_promotion")]
        public bool InsurePromotion { get; set; }

        /// <summary>
        /// 订单表最近一次修改时间
        /// </summary>
        [XmlElement("modify_time")]
        public string ModifyTime { get; set; }

        /// <summary>
        /// 淘宝机票订单id
        /// </summary>
        [XmlElement("order_id")]
        public long OrderId { get; set; }

        /// <summary>
        /// 订单最晚支付时间
        /// </summary>
        [XmlElement("pay_latest_time")]
        public string PayLatestTime { get; set; }

        /// <summary>
        /// 订单支付状态==> 0:未付款;1:已付款，冻结买家定金;2:付款给卖家;3:解冻定金给买家;4:已扣佣;5:交易关闭;6:确认可支付;7:确认不可支付
        /// </summary>
        [XmlElement("pay_status")]
        public long PayStatus { get; set; }

        /// <summary>
        /// 联系人邮箱
        /// </summary>
        [XmlElement("relation_email")]
        public string RelationEmail { get; set; }

        /// <summary>
        /// 联系人手机号
        /// </summary>
        [XmlElement("relation_mobile")]
        public string RelationMobile { get; set; }

        /// <summary>
        /// 联系人姓名
        /// </summary>
        [XmlElement("relation_name")]
        public string RelationName { get; set; }

        /// <summary>
        /// 联系人备用电话
        /// </summary>
        [XmlElement("relation_phone_bak")]
        public string RelationPhoneBak { get; set; }

        /// <summary>
        /// 订单状态定义==> 0:未付款;(注：支持保险分润时，订单已付款，保险未付款也为0)1:处理中;2:确定出票;3:预定成功;4:预定失败;5:处理中超时失效;6:支付超时失效;7:买家取消
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 总金额，所有乘机人加机建燃油，单位：分
        /// </summary>
        [XmlElement("total_price")]
        public long TotalPrice { get; set; }

        /// <summary>
        /// 航程类型：0，单程；1，往返；
        /// </summary>
        [XmlElement("trip_type")]
        public long TripType { get; set; }
    }
}
