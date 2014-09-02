using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// FavoriteItem Data Structure.
    /// </summary>
    [Serializable]
    public class FavoriteItem : TopObject
    {
        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 商品图片地址
        /// </summary>
        [XmlElement("item_pictrue")]
        public string ItemPictrue { get; set; }

        /// <summary>
        /// 商品价格
        /// </summary>
        [XmlElement("item_price")]
        public string ItemPrice { get; set; }

        /// <summary>
        /// 商品的详情页面地址
        /// </summary>
        [XmlElement("item_url")]
        public string ItemUrl { get; set; }

        /// <summary>
        /// 促销价格
        /// </summary>
        [XmlElement("promotion_price")]
        public string PromotionPrice { get; set; }

        /// <summary>
        /// 商品销售次数
        /// </summary>
        [XmlElement("sell_count")]
        public long SellCount { get; set; }

        /// <summary>
        /// 商品id（具有跟踪效果）代替原来的item_id  <a href="http://dev.open.taobao.com/bbs/read.php?tid=24323">详细说明</a>
        /// </summary>
        [XmlElement("track_iid")]
        public string TrackIid { get; set; }
    }
}
