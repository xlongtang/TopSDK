using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallItemsDiscountSearchResponse.
    /// </summary>
    public class TmallItemsDiscountSearchResponse : TopResponse
    {
        /// <summary>
        /// 搜索结果品牌列表
        /// </summary>
        [XmlArray("brand_list")]
        [XmlArrayItem("tmall_brand")]
        public List<TmallBrand> BrandList { get; set; }

        /// <summary>
        /// 搜索结果类目列表
        /// </summary>
        [XmlArray("cat_list")]
        [XmlArrayItem("tmall_cat")]
        public List<TmallCat> CatList { get; set; }

        /// <summary>
        /// 搜索结果宝贝列表
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("tmall_search_item")]
        public List<TmallSearchItem> ItemList { get; set; }

        /// <summary>
        /// 搜索结果minisite列表
        /// </summary>
        [XmlArray("minisite_list")]
        [XmlArrayItem("tmall_minisite")]
        public List<TmallMinisite> MinisiteList { get; set; }

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
        /// 搜索关键词
        /// </summary>
        [XmlElement("param_value")]
        public string ParamValue { get; set; }

        /// <summary>
        /// 搜索的URL
        /// </summary>
        [XmlElement("search_url")]
        public string SearchUrl { get; set; }

        /// <summary>
        /// 搜索总页数
        /// </summary>
        [XmlElement("total_page")]
        public long TotalPage { get; set; }

        /// <summary>
        /// 搜索结果总数
        /// </summary>
        [XmlElement("total_results")]
        public string TotalResults { get; set; }
    }
}
