using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// INWordCategory Data Structure.
    /// </summary>
    [Serializable]
    public class INWordCategory : TopObject
    {
        /// <summary>
        /// 词在类目下平均点击价格
        /// </summary>
        [XmlElement("avg_price")]
        public long AvgPrice { get; set; }

        /// <summary>
        /// 类目id
        /// </summary>
        [XmlElement("category_id")]
        public long CategoryId { get; set; }

        /// <summary>
        /// 词在类目下点击量
        /// </summary>
        [XmlElement("click")]
        public long Click { get; set; }

        /// <summary>
        /// 词在类目下竞争宝贝数(包括未展现客户)
        /// </summary>
        [XmlElement("competition")]
        public long Competition { get; set; }

        /// <summary>
        /// 点击率
        /// </summary>
        [XmlElement("ctr")]
        public string Ctr { get; set; }

        /// <summary>
        /// 时间点
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 词在类目下展现量
        /// </summary>
        [XmlElement("pv")]
        public long Pv { get; set; }

        /// <summary>
        /// 词名称
        /// </summary>
        [XmlElement("word")]
        public string Word { get; set; }
    }
}
