using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// BookBill Data Structure.
    /// </summary>
    [Serializable]
    public class BookBill : TopObject
    {
        /// <summary>
        /// 虚拟账户科目编号
        /// </summary>
        [XmlElement("account_id")]
        public long AccountId { get; set; }

        /// <summary>
        /// 操作金额
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 虚拟账户流水编号
        /// </summary>
        [XmlElement("bid")]
        public long Bid { get; set; }

        /// <summary>
        /// 记账时间
        /// </summary>
        [XmlElement("book_time")]
        public string BookTime { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 流水类型:101-可用金充值;102-可用金扣除;103-冻结;104-解冻;105-冻结金充值;106-冻结金扣除
        /// </summary>
        [XmlElement("journal_type")]
        public long JournalType { get; set; }

        /// <summary>
        /// 流水的商家支付宝id
        /// </summary>
        [XmlElement("other_alipay_id")]
        public string OtherAlipayId { get; set; }

        /// <summary>
        /// 流水的淘宝支付宝id
        /// </summary>
        [XmlElement("taobao_alipay_id")]
        public string TaobaoAlipayId { get; set; }
    }
}
