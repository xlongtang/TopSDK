using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WlbOrderPageGetResponse.
    /// </summary>
    public class WlbOrderPageGetResponse : TopResponse
    {
        /// <summary>
        /// 分页查询返回结果
        /// </summary>
        [XmlArray("order_list")]
        [XmlArrayItem("wlb_order")]
        public List<WlbOrder> OrderList { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
