using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// SpContentDOForList Data Structure.
    /// </summary>
    [Serializable]
    public class SpContentDOForList : TopObject
    {
        /// <summary>
        /// 类型为文章的内容摘要
        /// </summary>
        [XmlElement("articleabstract")]
        public string Articleabstract { get; set; }

        /// <summary>
        /// 分类名称
        /// </summary>
        [XmlElement("classname")]
        public string Classname { get; set; }

        /// <summary>
        /// 评论数
        /// </summary>
        [XmlElement("commentnum")]
        public long Commentnum { get; set; }

        /// <summary>
        /// 推荐理
        /// </summary>
        [XmlElement("comments")]
        public string Comments { get; set; }

        /// <summary>
        /// 内容的detail页面地址，数值为html链接，主要用于展现内容的detail信息的
        /// </summary>
        [XmlElement("detailurl")]
        public string Detailurl { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmtcreate")]
        public string Gmtcreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmtmodified")]
        public string Gmtmodified { get; set; }

        /// <summary>
        /// 内容主键ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 喜欢数
        /// </summary>
        [XmlElement("likenum")]
        public long Likenum { get; set; }

        /// <summary>
        /// 主图
        /// </summary>
        [XmlElement("mainpic")]
        public string Mainpic { get; set; }

        /// <summary>
        /// 图片URL,多个图片中间以,分割
        /// </summary>
        [XmlElement("picurl")]
        public string Picurl { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 内容平台的内容id
        /// </summary>
        [XmlElement("referid")]
        public long Referid { get; set; }

        /// <summary>
        /// 内容关联到的商品。如果有多个商品，用,分割
        /// </summary>
        [XmlElement("referitems")]
        public string Referitems { get; set; }

        /// <summary>
        /// 内容类型:   uz.item:宝贝  uz.image:图片  uz.article:自定义  uz.graphic:图文
        /// </summary>
        [XmlElement("schemaname")]
        public string Schemaname { get; set; }

        /// <summary>
        /// 分享数
        /// </summary>
        [XmlElement("sharenum")]
        public long Sharenum { get; set; }

        /// <summary>
        /// 物种ID
        /// </summary>
        [XmlElement("sitecategoryid")]
        public long Sitecategoryid { get; set; }

        /// <summary>
        /// 站点ID
        /// </summary>
        [XmlElement("taesiteid")]
        public long Taesiteid { get; set; }

        /// <summary>
        /// 标签名称。多个标签以,分割
        /// </summary>
        [XmlElement("tags")]
        public string Tags { get; set; }

        /// <summary>
        /// 附着目标的目标id
        /// </summary>
        [XmlElement("targetid")]
        public long Targetid { get; set; }

        /// <summary>
        /// 内容标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 是否置顶
        /// </summary>
        [XmlElement("topenable")]
        public long Topenable { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("userid")]
        public long Userid { get; set; }

        /// <summary>
        /// 浏览数
        /// </summary>
        [XmlElement("viewnum")]
        public long Viewnum { get; set; }
    }
}
