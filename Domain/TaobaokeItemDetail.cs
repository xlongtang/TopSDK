using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TaobaokeItemDetail Data Structure.
    /// </summary>
    [Serializable]
    public class TaobaokeItemDetail : TopObject
    {
        /// <summary>
        /// 商品推广URL
        /// </summary>
        [XmlElement("click_url")]
        public string ClickUrl { get; set; }

        /// <summary>
        /// 商品详细信息. fields中需要设置Item下的字段,如设置:iid,detail_url等; 只设置item_detail,则不返回的Item下的所有信息.
        /// </summary>
        [XmlElement("item")]
        public Item Item { get; set; }

        /// <summary>
        /// 商品所属卖家的信用等级
        /// </summary>
        [XmlElement("seller_credit_score")]
        public long SellerCreditScore { get; set; }

        /// <summary>
        /// 商品所在的店铺的推广URL
        /// </summary>
        [XmlElement("shop_click_url")]
        public string ShopClickUrl { get; set; }
    }
}
