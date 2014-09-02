using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// ExtraAttributes Data Structure.
    /// </summary>
    [Serializable]
    public class ExtraAttributes : TopObject
    {
        /// <summary>
        /// 商品在淘宝的发布时间
        /// </summary>
        [XmlElement("publish_time")]
        public string PublishTime { get; set; }

        /// <summary>
        /// 库存数量
        /// </summary>
        [XmlElement("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// 商品的累积销量
        /// </summary>
        [XmlElement("sales_count")]
        public string SalesCount { get; set; }
    }
}
