using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TakeoutShop Data Structure.
    /// </summary>
    [Serializable]
    public class TakeoutShop : TopObject
    {
        /// <summary>
        /// 店铺地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 商户类型 （1：品牌连锁  2:代理商  3：单店经营）
        /// </summary>
        [XmlElement("merchant_type")]
        public long MerchantType { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 店铺标志图片
        /// </summary>
        [XmlElement("pic_url")]
        public string PicUrl { get; set; }

        /// <summary>
        /// 地图坐标x，注意此坐标是乘以100000后的值
        /// </summary>
        [XmlElement("posx")]
        public long Posx { get; set; }

        /// <summary>
        /// 地图坐标y，注意此坐标是乘以100000后的值
        /// </summary>
        [XmlElement("posy")]
        public long Posy { get; set; }

        /// <summary>
        /// 外卖店铺id
        /// </summary>
        [XmlElement("shopid")]
        public long Shopid { get; set; }

        /// <summary>
        /// 店铺与ISV的关联关系
        /// </summary>
        [XmlElement("shopoutid")]
        public string Shopoutid { get; set; }
    }
}
