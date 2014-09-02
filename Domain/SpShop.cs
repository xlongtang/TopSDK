using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// SpShop Data Structure.
    /// </summary>
    [Serializable]
    public class SpShop : TopObject
    {
        /// <summary>
        /// 店铺好评率，即店铺累计好评数/店铺评价总数。
        /// </summary>
        [XmlElement("gerd")]
        public string Gerd { get; set; }

        /// <summary>
        /// 卖家信用等级,如果是天猫店铺则返回空值
        /// </summary>
        [XmlElement("seller_credit")]
        public string SellerCredit { get; set; }

        /// <summary>
        /// 店铺标题
        /// </summary>
        [XmlElement("shop_title")]
        public string ShopTitle { get; set; }

        /// <summary>
        /// 店铺的链接URL
        /// </summary>
        [XmlElement("shop_url")]
        public string ShopUrl { get; set; }

        /// <summary>
        /// 是否天猫： 1是，0否
        /// </summary>
        [XmlElement("tmall")]
        public string Tmall { get; set; }
    }
}
