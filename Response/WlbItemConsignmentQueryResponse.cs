using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WlbItemConsignmentQueryResponse.
    /// </summary>
    public class WlbItemConsignmentQueryResponse : TopResponse
    {
        /// <summary>
        /// 商品信息列表
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("wlb_item")]
        public List<WlbItem> ItemList { get; set; }

        /// <summary>
        /// 结果总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
