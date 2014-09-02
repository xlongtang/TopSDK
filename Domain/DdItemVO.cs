using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// DdItemVO Data Structure.
    /// </summary>
    [Serializable]
    public class DdItemVO : TopObject
    {
        /// <summary>
        /// 用户点菜份数
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 淘点点菜品id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 菜品名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 外部菜品编号
        /// </summary>
        [XmlElement("out_id")]
        public string OutId { get; set; }

        /// <summary>
        /// 外部skuid
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 菜品出售价格
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 淘点点skuid
        /// </summary>
        [XmlElement("sku_id")]
        public long SkuId { get; set; }

        /// <summary>
        /// sku名称
        /// </summary>
        [XmlElement("sku_name")]
        public string SkuName { get; set; }

        /// <summary>
        /// 点菜单菜品状态
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }
    }
}
