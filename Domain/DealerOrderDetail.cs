using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// DealerOrderDetail Data Structure.
    /// </summary>
    [Serializable]
    public class DealerOrderDetail : TopObject
    {
        /// <summary>
        /// 经销采购单明细id
        /// </summary>
        [XmlElement("dealer_detail_id")]
        public long DealerDetailId { get; set; }

        /// <summary>
        /// 经销采购单编号
        /// </summary>
        [XmlElement("dealer_order_id")]
        public long DealerOrderId { get; set; }

        /// <summary>
        /// 最终价格(精确到2位小数;单位:元。如:200.07，表示:200元7分 )
        /// </summary>
        [XmlElement("final_price")]
        public string FinalPrice { get; set; }

        /// <summary>
        /// 该条明细是否已删除。true：已删除；false：未删除。
        /// </summary>
        [XmlElement("is_deleted")]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// 原始价格(精确到2位小数;单位:元。如:200.07，表示:200元7分 )
        /// </summary>
        [XmlElement("original_price")]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 金额小计(采购数量乘以最终价格。精确到2位小数;单位:元。如:200.07，表示:200元7分 )
        /// </summary>
        [XmlElement("price_count")]
        public string PriceCount { get; set; }

        /// <summary>
        /// 产品id
        /// </summary>
        [XmlElement("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 产品标题
        /// </summary>
        [XmlElement("product_title")]
        public string ProductTitle { get; set; }

        /// <summary>
        /// 采购数量
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// sku id
        /// </summary>
        [XmlElement("sku_id")]
        public long SkuId { get; set; }

        /// <summary>
        /// 商家编码，是sku则为sku的商家编码，否则是产品的商家编码
        /// </summary>
        [XmlElement("sku_number")]
        public string SkuNumber { get; set; }

        /// <summary>
        /// 产品规格
        /// </summary>
        [XmlElement("sku_spec")]
        public string SkuSpec { get; set; }

        /// <summary>
        /// 产品快照url
        /// </summary>
        [XmlElement("snapshot_url")]
        public string SnapshotUrl { get; set; }
    }
}
