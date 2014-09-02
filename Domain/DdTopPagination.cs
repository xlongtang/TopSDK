using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// DdTopPagination Data Structure.
    /// </summary>
    [Serializable]
    public class DdTopPagination : TopObject
    {
        /// <summary>
        /// 结果列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("dd_top_reserved_v_o")]
        public List<DdTopReservedVO> List { get; set; }

        /// <summary>
        /// 翻页游码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页面大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 可返回的记录数
        /// </summary>
        [XmlElement("view_count")]
        public long ViewCount { get; set; }
    }
}
