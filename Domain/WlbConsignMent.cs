using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// WlbConsignMent Data Structure.
    /// </summary>
    [Serializable]
    public class WlbConsignMent : TopObject
    {
        /// <summary>
        /// 代销关系id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 代销商用户前台宝贝id
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// 代销数量
        /// </summary>
        [XmlElement("number")]
        public long Number { get; set; }

        /// <summary>
        /// 供应商商品id
        /// </summary>
        [XmlElement("tgt_item_id")]
        public long TgtItemId { get; set; }

        /// <summary>
        /// 供应商用户id
        /// </summary>
        [XmlElement("tgt_user_id")]
        public long TgtUserId { get; set; }

        /// <summary>
        /// 代销商用户id
        /// </summary>
        [XmlElement("user_id")]
        public long UserId { get; set; }
    }
}
