using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// SellerPointRecordModule Data Structure.
    /// </summary>
    [Serializable]
    public class SellerPointRecordModule : TopObject
    {
        /// <summary>
        /// 业务扩展信息 ，用于ISV描述积分记录的具体业务信息
        /// </summary>
        [XmlElement("business_info")]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// 买家NICK
        /// </summary>
        [XmlElement("buyer_nick")]
        public string BuyerNick { get; set; }

        /// <summary>
        /// 积分数量
        /// </summary>
        [XmlElement("point_num")]
        public long PointNum { get; set; }

        /// <summary>
        /// 记录状态 1成功 0冻结 -1失败
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// upp内部业务ID，由预扣或预发积分接口返回，ISV可以直接使用，或映射自己的业务ID。
        /// </summary>
        [XmlElement("transaction_id")]
        public long TransactionId { get; set; }

        /// <summary>
        /// 业务发生时间
        /// </summary>
        [XmlElement("transaction_time")]
        public string TransactionTime { get; set; }

        /// <summary>
        /// 3：ISV送积分    4：ISV扣减积分
        /// </summary>
        [XmlElement("type")]
        public long Type { get; set; }
    }
}
