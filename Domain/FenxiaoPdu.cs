using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// FenxiaoPdu Data Structure.
    /// </summary>
    [Serializable]
    public class FenxiaoPdu : TopObject
    {
        /// <summary>
        /// 分销商ID
        /// </summary>
        [XmlElement("distributor_id")]
        public long DistributorId { get; set; }

        /// <summary>
        /// 分销商用户名
        /// </summary>
        [XmlElement("distributor_name")]
        public string DistributorName { get; set; }

        /// <summary>
        /// 产品ID
        /// </summary>
        [XmlElement("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 产品代销配额库存
        /// </summary>
        [XmlElement("quantity_agent")]
        public long QuantityAgent { get; set; }

        /// <summary>
        /// 产品销售属性值
        /// </summary>
        [XmlElement("sku_properties")]
        public string SkuProperties { get; set; }
    }
}
