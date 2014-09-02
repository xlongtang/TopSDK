using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// ScitemQueryResponse.
    /// </summary>
    public class ScitemQueryResponse : TopResponse
    {
        /// <summary>
        /// 当前所在页数
        /// </summary>
        [XmlElement("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 返回商品列表的页数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 分页
        /// </summary>
        [XmlElement("query_pagination")]
        public QueryPagination QueryPagination { get; set; }

        /// <summary>
        /// List<ScItemDO>
        /// </summary>
        [XmlArray("sc_item_list")]
        [XmlArrayItem("sc_item")]
        public List<ScItem> ScItemList { get; set; }

        /// <summary>
        /// 商品条数
        /// </summary>
        [XmlElement("total_page")]
        public long TotalPage { get; set; }
    }
}
