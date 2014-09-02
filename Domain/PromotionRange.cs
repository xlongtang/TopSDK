using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// PromotionRange Data Structure.
    /// </summary>
    [Serializable]
    public class PromotionRange : TopObject
    {
        /// <summary>
        /// 活动id。
        /// </summary>
        [XmlElement("activity_id")]
        public long ActivityId { get; set; }

        /// <summary>
        /// 活动名称。
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 参与活动的商品id。
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }
    }
}
