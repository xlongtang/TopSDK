using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// PromotionInShop Data Structure.
    /// </summary>
    [Serializable]
    public class PromotionInShop : TopObject
    {
        /// <summary>
        /// 优惠活动名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 优惠详情描述。
        /// </summary>
        [XmlElement("promotion_detail_desc")]
        public string PromotionDetailDesc { get; set; }

        /// <summary>
        /// idValue值
        /// </summary>
        [XmlElement("promotion_id")]
        public string PromotionId { get; set; }
    }
}
