using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// ShopScore Data Structure.
    /// </summary>
    [Serializable]
    public class ShopScore : TopObject
    {
        /// <summary>
        /// 发货速度评分
        /// </summary>
        [XmlElement("delivery_score")]
        public string DeliveryScore { get; set; }

        /// <summary>
        /// 商品描述评分
        /// </summary>
        [XmlElement("item_score")]
        public string ItemScore { get; set; }

        /// <summary>
        /// 服务态度评分
        /// </summary>
        [XmlElement("service_score")]
        public string ServiceScore { get; set; }
    }
}
