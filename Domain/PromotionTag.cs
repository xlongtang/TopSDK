using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// PromotionTag Data Structure.
    /// </summary>
    [Serializable]
    public class PromotionTag : TopObject
    {
        /// <summary>
        /// 标签结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 标签开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 标签描述
        /// </summary>
        [XmlElement("tag_desc")]
        public string TagDesc { get; set; }

        /// <summary>
        /// 标签ID
        /// </summary>
        [XmlElement("tag_id")]
        public long TagId { get; set; }

        /// <summary>
        /// 标签名称
        /// </summary>
        [XmlElement("tag_name")]
        public string TagName { get; set; }
    }
}
