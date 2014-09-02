using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WlbReplenishStatisticsResponse.
    /// </summary>
    public class WlbReplenishStatisticsResponse : TopResponse
    {
        /// <summary>
        /// 补货统计列表
        /// </summary>
        [XmlArray("replenish_list")]
        [XmlArrayItem("wlb_replenish")]
        public List<WlbReplenish> ReplenishList { get; set; }

        /// <summary>
        /// 查询记录总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
