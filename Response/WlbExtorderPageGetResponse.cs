using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WlbExtorderPageGetResponse.
    /// </summary>
    public class WlbExtorderPageGetResponse : TopResponse
    {
        /// <summary>
        /// 分页查询返回结果
        /// </summary>
        [XmlArray("ext_order_list")]
        [XmlArrayItem("wlb_ext_order")]
        public List<WlbExtOrder> ExtOrderList { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
