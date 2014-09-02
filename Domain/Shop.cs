using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// Shop Data Structure.
    /// </summary>
    [Serializable]
    public class Shop : TopObject
    {
        /// <summary>
        /// 总橱窗数量，对于C卖家返回总橱窗数，对于B卖家返回0（只有taobao.shop.remainshowcase.get可以返回）
        /// </summary>
        [XmlElement("all_count")]
        public long AllCount { get; set; }

        /// <summary>
        /// 店铺公告
        /// </summary>
        [XmlElement("bulletin")]
        public string Bulletin { get; set; }

        /// <summary>
        /// 店铺所属的类目编号
        /// </summary>
        [XmlElement("cid")]
        public long Cid { get; set; }

        /// <summary>
        /// 开店时间。格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 店铺描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 最后修改时间。格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("modified")]
        public string Modified { get; set; }

        /// <summary>
        /// 卖家昵称
        /// </summary>
        [XmlElement("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 店标地址。返回相对路径，可以用"http://logo.taobao.com/shop-logo"来拼接成绝对路径
        /// </summary>
        [XmlElement("pic_path")]
        public string PicPath { get; set; }

        /// <summary>
        /// 剩余橱窗数量，对于C卖家返回剩余橱窗数，对于B卖家返回-1（只有taobao.shop.remainshowcase.get可以返回）
        /// </summary>
        [XmlElement("remain_count")]
        public long RemainCount { get; set; }

        /// <summary>
        /// 店铺动态评分信息
        /// </summary>
        [XmlElement("shop_score")]
        public ShopScore ShopScore { get; set; }

        /// <summary>
        /// 店铺编号。shop+sid.taobao.com即店铺地址，如shop123456.taobao.com
        /// </summary>
        [XmlElement("sid")]
        public long Sid { get; set; }

        /// <summary>
        /// 店铺标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 已用的橱窗数量，对于C卖家返回已使用的橱窗数，对于B卖家返回-1（只有taobao.shop.remainshowcase.get可以返回）
        /// </summary>
        [XmlElement("used_count")]
        public long UsedCount { get; set; }
    }
}
