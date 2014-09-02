using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// LotteryWangcaiPresentStat Data Structure.
    /// </summary>
    [Serializable]
    public class LotteryWangcaiPresentStat : TopObject
    {
        /// <summary>
        /// 日期
        /// </summary>
        [XmlElement("date_id")]
        public long DateId { get; set; }

        /// <summary>
        /// 当日赠送彩票的金额
        /// </summary>
        [XmlElement("present_fee")]
        public long PresentFee { get; set; }

        /// <summary>
        /// 当日赠送彩票的注数
        /// </summary>
        [XmlElement("present_stake")]
        public long PresentStake { get; set; }

        /// <summary>
        /// 当日赠送用户数
        /// </summary>
        [XmlElement("present_user")]
        public long PresentUser { get; set; }

        /// <summary>
        /// 送彩方的淘宝数字ID
        /// </summary>
        [XmlElement("seller_id")]
        public long SellerId { get; set; }
    }
}
