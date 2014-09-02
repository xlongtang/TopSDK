using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// KeywordPage Data Structure.
    /// </summary>
    [Serializable]
    public class KeywordPage : TopObject
    {
        /// <summary>
        /// 关键词列表
        /// </summary>
        [XmlArray("keyword_list")]
        [XmlArrayItem("keyword")]
        public List<Keyword> KeywordList { get; set; }

        /// <summary>
        /// 返回第几页的数据从1开始
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页数据大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 所查询的数据总数，只有当返回第一页数据时有值，当要求返回的数据非第一页时，此返回值无效
        /// </summary>
        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
