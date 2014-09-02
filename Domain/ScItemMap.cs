using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// ScItemMap Data Structure.
    /// </summary>
    [Serializable]
    public class ScItemMap : TopObject
    {
        /// <summary>
        /// map_type=1时，item_id为IC商品id    map_type=7时，item_id为分销商品id
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// 1:前台和后台关系  7:分销和后台关系
        /// </summary>
        [XmlElement("map_type")]
        public long MapType { get; set; }

        /// <summary>
        /// 后端商品ID
        /// </summary>
        [XmlElement("rel_item_id")]
        public long RelItemId { get; set; }

        /// <summary>
        /// 后端商品所有者商家编码
        /// </summary>
        [XmlElement("rel_outer_code")]
        public string RelOuterCode { get; set; }

        /// <summary>
        /// 后端商品所有者id
        /// </summary>
        [XmlElement("rel_user_id")]
        public long RelUserId { get; set; }

        /// <summary>
        /// 后端商品所有者名称
        /// </summary>
        [XmlElement("rel_user_nick")]
        public string RelUserNick { get; set; }

        /// <summary>
        /// 当宝贝下没SKU时该字段为空
        /// </summary>
        [XmlElement("sku_id")]
        public long SkuId { get; set; }

        /// <summary>
        /// Ic商家id(分销商id)
        /// </summary>
        [XmlElement("user_id")]
        public long UserId { get; set; }

        /// <summary>
        /// Ic商家nick(分销商nick)
        /// </summary>
        [XmlElement("user_nick")]
        public string UserNick { get; set; }
    }
}
