using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// ItemRecommendDeleteResponse.
    /// </summary>
    public class ItemRecommendDeleteResponse : TopResponse
    {
        /// <summary>
        /// 被取消橱窗推荐的商品信息
        /// </summary>
        [XmlElement("item")]
        public Item Item { get; set; }
    }
}
