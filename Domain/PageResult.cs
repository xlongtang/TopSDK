using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// PageResult Data Structure.
    /// </summary>
    [Serializable]
    public class PageResult : TopObject
    {
        /// <summary>
        /// 用户查询时是第几页
        /// </summary>
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 每页多少条记录
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 查询时是分页查询，则返回总条数。
        /// </summary>
        [XmlElement("total_amount")]
        public long TotalAmount { get; set; }

        /// <summary>
        /// 一共多少页 结果
        /// </summary>
        [XmlElement("total_page")]
        public long TotalPage { get; set; }
    }
}
