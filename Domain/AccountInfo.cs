using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// AccountInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AccountInfo : TopObject
    {
        /// <summary>
        /// 账号
        /// </summary>
        [XmlElement("account")]
        public string Account { get; set; }

        /// <summary>
        /// 操作列表
        /// </summary>
        [XmlArray("account_stats")]
        [XmlArrayItem("account_stat")]
        public List<AccountStat> AccountStats { get; set; }

        /// <summary>
        /// account_stats列表的长度
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }
    }
}
