using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// ImprItemDO Data Structure.
    /// </summary>
    [Serializable]
    public class ImprItemDO : TopObject
    {
        /// <summary>
        /// 印象标签的id
        /// </summary>
        [XmlElement("attribute_id")]
        public long AttributeId { get; set; }

        /// <summary>
        /// 被买家评价提及到的印象标签次数
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 印象标签情感倾向 1表示正面 -1表示负面 0表示中性
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 印象标签的名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
