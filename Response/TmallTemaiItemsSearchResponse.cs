using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallTemaiItemsSearchResponse.
    /// </summary>
    public class TmallTemaiItemsSearchResponse : TopResponse
    {
        /// <summary>
        /// 特卖搜索结果宝贝列表
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("tmall_search_tm_item")]
        public List<TmallSearchTmItem> ItemList { get; set; }

        /// <summary>
        /// 当前页数
        /// </summary>
        [XmlElement("page")]
        public long Page { get; set; }

        /// <summary>
        /// 每页搜索返回数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 搜索总页数
        /// </summary>
        [XmlElement("total_page")]
        public long TotalPage { get; set; }

        /// <summary>
        /// 搜索结果总数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
