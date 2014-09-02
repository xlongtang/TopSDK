using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// DistributorItemFlow Data Structure.
    /// </summary>
    [Serializable]
    public class DistributorItemFlow : TopObject
    {
        /// <summary>
        /// 分销商商品PV。返回KV串中可能不足一周数据，如新上架商品、中间下架以及删除等操作导致。
        /// </summary>
        [XmlElement("item_pv")]
        public string ItemPv { get; set; }

        /// <summary>
        /// 分销商商品UV。返回KV串中可能不足一周数据，如新上架商品、中间下架以及删除等操作导致。
        /// </summary>
        [XmlElement("item_uv")]
        public string ItemUv { get; set; }

        /// <summary>
        /// 产品ID
        /// </summary>
        [XmlElement("product_id")]
        public long ProductId { get; set; }
    }
}
