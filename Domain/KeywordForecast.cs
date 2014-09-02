using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// KeywordForecast Data Structure.
    /// </summary>
    [Serializable]
    public class KeywordForecast : TopObject
    {
        /// <summary>
        /// 词ID
        /// </summary>
        [XmlElement("keyword_id")]
        public long KeywordId { get; set; }

        /// <summary>
        /// 主人昵称
        /// </summary>
        [XmlElement("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 点击预估；根据出价预估点击量  40:784,50:1007表示出价40分点击量为783；出价50分点击量为1007
        /// </summary>
        [XmlElement("price_click")]
        public string PriceClick { get; set; }

        /// <summary>
        /// 消耗预估；根据出价预估消耗。40:20,50:21表示出价40元分，消耗20分；出价50分消耗21分
        /// </summary>
        [XmlElement("price_cust")]
        public string PriceCust { get; set; }

        /// <summary>
        /// 排名预估;根据出价预估排名。  40:101,41:101表示出价40分排名101位；出价41分排名101位
        /// </summary>
        [XmlElement("price_rank")]
        public string PriceRank { get; set; }

        /// <summary>
        /// 词名称
        /// </summary>
        [XmlElement("word")]
        public string Word { get; set; }
    }
}
