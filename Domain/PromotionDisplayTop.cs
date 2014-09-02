using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// PromotionDisplayTop Data Structure.
    /// </summary>
    [Serializable]
    public class PromotionDisplayTop : TopObject
    {
        /// <summary>
        /// 单品级优惠信息
        /// </summary>
        [XmlArray("promotion_in_item")]
        [XmlArrayItem("promotion_in_item")]
        public List<PromotionInItem> PromotionInItem { get; set; }

        /// <summary>
        /// 店铺级优惠信息
        /// </summary>
        [XmlArray("promotion_in_shop")]
        [XmlArrayItem("promotion_in_shop")]
        public List<PromotionInShop> PromotionInShop { get; set; }
    }
}
