using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// ItemRecommendAddResponse.
    /// </summary>
    public class ItemRecommendAddResponse : TopResponse
    {
        /// <summary>
        /// 被推荐的商品的信息
        /// </summary>
        [XmlElement("item")]
        public Item Item { get; set; }
    }
}
