using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// ProductCat Data Structure.
    /// </summary>
    [Serializable]
    public class ProductCat : TopObject
    {
        /// <summary>
        /// 代销采购价百分比
        /// </summary>
        [XmlElement("cost_percent_agent")]
        public string CostPercentAgent { get; set; }

        /// <summary>
        /// 经销采购价百分比
        /// </summary>
        [XmlElement("cost_percent_dealer")]
        public string CostPercentDealer { get; set; }

        /// <summary>
        /// 产品线ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 产品线名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 产品数量
        /// </summary>
        [XmlElement("product_num")]
        public long ProductNum { get; set; }

        /// <summary>
        /// 最高零食价百分比
        /// </summary>
        [XmlElement("retail_high_percent")]
        public string RetailHighPercent { get; set; }

        /// <summary>
        /// 最低零售价百分比
        /// </summary>
        [XmlElement("retail_low_percent")]
        public string RetailLowPercent { get; set; }
    }
}
