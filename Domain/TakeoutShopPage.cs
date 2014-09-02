using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// TakeoutShopPage Data Structure.
    /// </summary>
    [Serializable]
    public class TakeoutShopPage : TopObject
    {
        /// <summary>
        /// 下一页页码
        /// </summary>
        [XmlElement("next_page")]
        public long NextPage { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page")]
        public long Page { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 上一页页码
        /// </summary>
        [XmlElement("prev_page")]
        public long PrevPage { get; set; }

        /// <summary>
        /// 店铺信息列表
        /// </summary>
        [XmlArray("takeout_summary_infos")]
        [XmlArrayItem("takeout_shop_summary_info")]
        public List<TakeoutShopSummaryInfo> TakeoutSummaryInfos { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_page")]
        public long TotalPage { get; set; }
    }
}
