using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// FenxiaoSku Data Structure.
    /// </summary>
    [Serializable]
    public class FenxiaoSku : TopObject
    {
        /// <summary>
        /// 代销采购价，单位：元
        /// </summary>
        [XmlElement("cost_price")]
        public string CostPrice { get; set; }

        /// <summary>
        /// 经销采购价
        /// </summary>
        [XmlElement("dealer_cost_price")]
        public string DealerCostPrice { get; set; }

        /// <summary>
        /// SkuID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 商家编码
        /// </summary>
        [XmlElement("outer_id")]
        public string OuterId { get; set; }

        /// <summary>
        /// sku的销售属性组合字符串。格式:pid:vid;pid:vid,如:1627207:3232483;1630696:3284570,表示:机身颜色:军绿色;手机套餐:一电一充。
        /// </summary>
        [XmlElement("properties")]
        public string Properties { get; set; }

        /// <summary>
        /// 库存
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 关联的后端商品id
        /// </summary>
        [XmlElement("scitem_id")]
        public long ScitemId { get; set; }

        /// <summary>
        /// 市场价
        /// </summary>
        [XmlElement("standard_price")]
        public string StandardPrice { get; set; }
    }
}
