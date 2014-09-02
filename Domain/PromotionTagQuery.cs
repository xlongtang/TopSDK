using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// PromotionTagQuery Data Structure.
    /// </summary>
    [Serializable]
    public class PromotionTagQuery : TopObject
    {
        /// <summary>
        /// 标签结果列表
        /// </summary>
        [XmlArray("tag_list")]
        [XmlArrayItem("promotion_tag")]
        public List<PromotionTag> TagList { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
