using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// WidgetSku Data Structure.
    /// </summary>
    [Serializable]
    public class WidgetSku : TopObject
    {
        /// <summary>
        /// sku的价格，对应Sku的price字段
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// sku的属性串，根据pid的大小从小到大排列，前后都加";"。类型Sku的properties字段
        /// </summary>
        [XmlElement("props")]
        public string Props { get; set; }

        /// <summary>
        /// sku的库存数量，对应Sku的quantity字段
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// sku的id，对应Sku的sku_id字段
        /// </summary>
        [XmlElement("sku_id")]
        public long SkuId { get; set; }
    }
}
