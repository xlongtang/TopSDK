using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// AuctionSkuDO Data Structure.
    /// </summary>
    [Serializable]
    public class AuctionSkuDO : TopObject
    {
        /// <summary>
        /// sku描述信息
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 商品宝贝id
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// sku对应外部编码
        /// </summary>
        [XmlElement("outer_id")]
        public string OuterId { get; set; }

        /// <summary>
        /// sku价格，以分为单位
        /// </summary>
        [XmlElement("price")]
        public long Price { get; set; }

        /// <summary>
        /// sku的属性及属性值id
        /// </summary>
        [XmlElement("properties")]
        public string Properties { get; set; }

        /// <summary>
        /// sku包含的属性对列表
        /// </summary>
        [XmlArray("pv_list")]
        [XmlArrayItem("auction_p_v_pair_d_o")]
        public List<AuctionPVPairDO> PvList { get; set; }

        /// <summary>
        /// sku的库存
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// sku_id
        /// </summary>
        [XmlElement("sku_id")]
        public long SkuId { get; set; }

        /// <summary>
        /// 状态  1：正常 -1：删除
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }
    }
}
