using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// RankedItem Data Structure.
    /// </summary>
    [Serializable]
    public class RankedItem : TopObject
    {
        /// <summary>
        /// 商品链接
        /// </summary>
        [XmlElement("link_url")]
        public string LinkUrl { get; set; }

        /// <summary>
        /// 最高出价
        /// </summary>
        [XmlElement("max_price")]
        public string MaxPrice { get; set; }

        /// <summary>
        /// 客户昵称
        /// </summary>
        [XmlElement("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 排名
        /// </summary>
        [XmlElement("order")]
        public long Order { get; set; }

        /// <summary>
        /// 原始质量评分
        /// </summary>
        [XmlElement("rank_score")]
        public long RankScore { get; set; }

        /// <summary>
        /// 创意标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
