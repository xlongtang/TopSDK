using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// GradeDiscount Data Structure.
    /// </summary>
    [Serializable]
    public class GradeDiscount : TopObject
    {
        /// <summary>
        /// 等级ID或分销商ID
        /// </summary>
        [XmlElement("discount_id")]
        public long DiscountId { get; set; }

        /// <summary>
        /// 折扣类型：1-等级、2-分销商折扣
        /// </summary>
        [XmlElement("discount_type")]
        public long DiscountType { get; set; }

        /// <summary>
        /// 采购价格
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// skuId
        /// </summary>
        [XmlElement("sku_id")]
        public long SkuId { get; set; }

        /// <summary>
        /// 模式：1-代销、2-经销
        /// </summary>
        [XmlElement("trade_type")]
        public long TradeType { get; set; }
    }
}
