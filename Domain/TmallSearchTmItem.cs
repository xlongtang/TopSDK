using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TmallSearchTmItem Data Structure.
    /// </summary>
    [Serializable]
    public class TmallSearchTmItem : TopObject
    {
        /// <summary>
        /// 宝贝所属品牌ID
        /// </summary>
        [XmlElement("brand_id")]
        public long BrandId { get; set; }

        /// <summary>
        /// 宝贝所属品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 宝贝评论数
        /// </summary>
        [XmlElement("comment_num")]
        public string CommentNum { get; set; }

        /// <summary>
        /// 宝贝佣金比（%）
        /// </summary>
        [XmlElement("commission_rate")]
        public string CommissionRate { get; set; }

        /// <summary>
        /// 搜索宝贝url
        /// </summary>
        [XmlElement("detail_url")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// 搜索宝贝的图片url
        /// </summary>
        [XmlElement("pic_url")]
        public string PicUrl { get; set; }

        /// <summary>
        /// 搜索宝贝原价
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 搜索宝贝特卖价
        /// </summary>
        [XmlElement("promotion_price")]
        public string PromotionPrice { get; set; }

        /// <summary>
        /// 宝贝热门标签名称
        /// </summary>
        [XmlElement("tag_hot")]
        public string TagHot { get; set; }

        /// <summary>
        /// 宝贝限量标签名称
        /// </summary>
        [XmlElement("tag_lq")]
        public string TagLq { get; set; }

        /// <summary>
        /// 宝贝新品标签名称
        /// </summary>
        [XmlElement("tag_new")]
        public string TagNew { get; set; }

        /// <summary>
        /// 搜索宝贝的标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 商品id（具有跟踪效果）代替原来的num_iid  <a href="http://dev.open.taobao.com/bbs/read.php?tid=24323">详细说明</a>
        /// </summary>
        [XmlElement("track_iid")]
        public string TrackIid { get; set; }

        /// <summary>
        /// 搜索宝贝的已售数量 （月销量）
        /// </summary>
        [XmlElement("volume")]
        public long Volume { get; set; }
    }
}
