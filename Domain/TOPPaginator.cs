using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TOPPaginator Data Structure.
    /// </summary>
    [Serializable]
    public class TOPPaginator : TopObject
    {
        /// <summary>
        /// 当前页码。取值范围:大于零的整数。默认值为1,即默认返回第一页数据。
        /// </summary>
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 是否最后一页
        /// </summary>
        [XmlElement("is_last_page")]
        public bool IsLastPage { get; set; }

        /// <summary>
        /// 每页条数。默认值：12
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 搜索到符合条件的结果总数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
