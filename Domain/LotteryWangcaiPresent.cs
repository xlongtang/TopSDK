using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// LotteryWangcaiPresent Data Structure.
    /// </summary>
    [Serializable]
    public class LotteryWangcaiPresent : TopObject
    {
        /// <summary>
        /// isv应用的名称
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 彩种名称
        /// </summary>
        [XmlElement("lottery_name")]
        public string LotteryName { get; set; }

        /// <summary>
        /// 赠送时间
        /// </summary>
        [XmlElement("present_date")]
        public string PresentDate { get; set; }

        /// <summary>
        /// 主键id
        /// </summary>
        [XmlElement("present_id")]
        public long PresentId { get; set; }

        /// <summary>
        /// 彩票注数
        /// </summary>
        [XmlElement("stake_count")]
        public long StakeCount { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 订单状态描述
        /// </summary>
        [XmlElement("status_desc")]
        public string StatusDesc { get; set; }

        /// <summary>
        /// 赠言
        /// </summary>
        [XmlElement("sweety_words")]
        public string SweetyWords { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        [XmlElement("user_nick")]
        public string UserNick { get; set; }

        /// <summary>
        /// 用户数字id
        /// </summary>
        [XmlElement("user_num_id")]
        public long UserNumId { get; set; }

        /// <summary>
        /// 中奖金额，以分为单位
        /// </summary>
        [XmlElement("win_fee")]
        public long WinFee { get; set; }
    }
}
