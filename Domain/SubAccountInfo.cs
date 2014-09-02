using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// SubAccountInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SubAccountInfo : TopObject
    {
        /// <summary>
        /// 子账号是否参与分流 true:参与分流 false:未参与分流
        /// </summary>
        [XmlElement("sub_dispatch_status")]
        public bool SubDispatchStatus { get; set; }

        /// <summary>
        /// 子账号Id
        /// </summary>
        [XmlElement("sub_id")]
        public long SubId { get; set; }

        /// <summary>
        /// 子账号用户名
        /// </summary>
        [XmlElement("sub_nick")]
        public string SubNick { get; set; }

        /// <summary>
        /// 子账号是否已欠费 true:已欠费 false:未欠费
        /// </summary>
        [XmlElement("sub_owed_status")]
        public bool SubOwedStatus { get; set; }

        /// <summary>
        /// 子账号当前状态：1正常，2卖家停用，3处罚冻结
        /// </summary>
        [XmlElement("sub_status")]
        public long SubStatus { get; set; }

        /// <summary>
        /// 主账号Id
        /// </summary>
        [XmlElement("user_id")]
        public long UserId { get; set; }

        /// <summary>
        /// 主账号用户名
        /// </summary>
        [XmlElement("user_nick")]
        public string UserNick { get; set; }
    }
}
