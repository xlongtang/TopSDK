using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// RefundItem Data Structure.
    /// </summary>
    [Serializable]
    public class RefundItem : TopObject
    {
        /// <summary>
        /// 商品数量
        /// </summary>
        [XmlElement("num")]
        public long Num { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("num_iid")]
        public long NumIid { get; set; }

        /// <summary>
        /// 商品外部商家编码
        /// </summary>
        [XmlElement("outer_id")]
        public string OuterId { get; set; }

        /// <summary>
        /// 商品价格
        /// </summary>
        [XmlElement("price")]
        public long Price { get; set; }

        /// <summary>
        /// sku信息
        /// </summary>
        [XmlElement("sku")]
        public string Sku { get; set; }
    }
}
