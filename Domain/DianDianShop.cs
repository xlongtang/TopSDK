using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// DianDianShop Data Structure.
    /// </summary>
    [Serializable]
    public class DianDianShop : TopObject
    {
        /// <summary>
        /// 店铺地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 别名
        /// </summary>
        [XmlElement("byname")]
        public string Byname { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 配送费
        /// </summary>
        [XmlElement("delivery_amount")]
        public string DeliveryAmount { get; set; }

        /// <summary>
        /// 配送范围坐标
        /// </summary>
        [XmlElement("delivery_range")]
        public string DeliveryRange { get; set; }

        /// <summary>
        /// 营业时间（配送时间）
        /// </summary>
        [XmlElement("delivery_time")]
        public string DeliveryTime { get; set; }

        /// <summary>
        /// 菜品列表的h5页面
        /// </summary>
        [XmlElement("detail_item_url")]
        public string DetailItemUrl { get; set; }

        /// <summary>
        /// 区域
        /// </summary>
        [XmlElement("district")]
        public string District { get; set; }

        /// <summary>
        /// 是否减免，无：0，减：1
        /// </summary>
        [XmlElement("jian")]
        public string Jian { get; set; }

        /// <summary>
        /// 维度
        /// </summary>
        [XmlElement("lat")]
        public string Lat { get; set; }

        /// <summary>
        /// 店铺logo
        /// </summary>
        [XmlElement("logo_url")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("lon")]
        public string Lon { get; set; }

        /// <summary>
        /// 起送金额
        /// </summary>
        [XmlElement("minimum_amount")]
        public string MinimumAmount { get; set; }

        /// <summary>
        /// 多级配送属性
        /// </summary>
        [XmlElement("multi_area_range")]
        public string MultiAreaRange { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 0:歇业，1:营业
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 店铺id
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 店铺子名称
        /// </summary>
        [XmlElement("subname")]
        public string Subname { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        [XmlElement("tel")]
        public string Tel { get; set; }
    }
}
