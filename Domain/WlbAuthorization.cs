using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// WlbAuthorization Data Structure.
    /// </summary>
    [Serializable]
    public class WlbAuthorization : TopObject
    {
        /// <summary>
        /// 授权结束时间
        /// </summary>
        [XmlElement("authorize_end_time")]
        public string AuthorizeEndTime { get; set; }

        /// <summary>
        /// 授权ID
        /// </summary>
        [XmlElement("authorize_id")]
        public long AuthorizeId { get; set; }

        /// <summary>
        /// 授权开始时间
        /// </summary>
        [XmlElement("authorize_start_time")]
        public string AuthorizeStartTime { get; set; }

        /// <summary>
        /// 代销人用户ID
        /// </summary>
        [XmlElement("consign_user_id")]
        public long ConsignUserId { get; set; }

        /// <summary>
        /// 授权商品ID
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// 授权名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 货主用户ID
        /// </summary>
        [XmlElement("owner_user_id")]
        public long OwnerUserId { get; set; }

        /// <summary>
        /// 授权数量
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 授权编码
        /// </summary>
        [XmlElement("rule_code")]
        public string RuleCode { get; set; }

        /// <summary>
        /// 状态：  VALID -- 1 有效  INVALIDATION -- 2 失效
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
