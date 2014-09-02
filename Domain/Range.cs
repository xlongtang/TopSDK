using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// Range Data Structure.
    /// </summary>
    [Serializable]
    public class Range : TopObject
    {
        /// <summary>
        /// 营销范围参与者id。即MarketingRangeDO中的participateId。
        /// </summary>
        [XmlElement("participate_id")]
        public long ParticipateId { get; set; }

        /// <summary>
        /// 营销范围参与者类型。MarketingRangeDO中的participateType。(1:商品;2:店铺;3:seller;4:sku;5:category;6:shopCategory)
        /// </summary>
        [XmlElement("participate_type")]
        public long ParticipateType { get; set; }
    }
}
