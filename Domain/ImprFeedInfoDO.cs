using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// ImprFeedInfoDO Data Structure.
    /// </summary>
    [Serializable]
    public class ImprFeedInfoDO : TopObject
    {
        /// <summary>
        /// 1:主评  2:追评
        /// </summary>
        [XmlElement("biz_type")]
        public long BizType { get; set; }

        /// <summary>
        /// 评价内容
        /// </summary>
        [XmlElement("feedback")]
        public string Feedback { get; set; }

        /// <summary>
        /// 评价创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 评价的修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 从评价内容里提取的语义标签
        /// </summary>
        [XmlArray("impr_words")]
        [XmlArrayItem("string")]
        public List<string> ImprWords { get; set; }
    }
}
