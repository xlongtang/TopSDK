using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// Account Data Structure.
    /// </summary>
    [Serializable]
    public class Account : TopObject
    {
        /// <summary>
        /// 费用科目编码
        /// </summary>
        [XmlElement("account_code")]
        public string AccountCode { get; set; }

        /// <summary>
        /// 费用科目编号
        /// </summary>
        [XmlElement("account_id")]
        public long AccountId { get; set; }

        /// <summary>
        /// 费用科目名称
        /// </summary>
        [XmlElement("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 费用科目类型:1-虚拟账户 2-交易 3-交易佣金 4-服务费 5-天猫积分 6-其他
        /// </summary>
        [XmlElement("account_type")]
        public long AccountType { get; set; }
    }
}
