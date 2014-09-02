using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// SubUserInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SubUserInfo : TopObject
    {
        /// <summary>
        /// 子账号姓名
        /// </summary>
        [XmlElement("full_name")]
        public string FullName { get; set; }

        /// <summary>
        /// 是否参与分流 1不参与 2参与
        /// </summary>
        [XmlElement("is_online")]
        public long IsOnline { get; set; }

        /// <summary>
        /// 子账号用户名
        /// </summary>
        [XmlElement("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 子账号所属的主账号的唯一标识
        /// </summary>
        [XmlElement("seller_id")]
        public long SellerId { get; set; }

        /// <summary>
        /// 主账号昵称
        /// </summary>
        [XmlElement("seller_nick")]
        public string SellerNick { get; set; }

        /// <summary>
        /// 子账号当前状态 1正常 -1删除  2冻结
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 子账号Id
        /// </summary>
        [XmlElement("sub_id")]
        public long SubId { get; set; }
    }
}
