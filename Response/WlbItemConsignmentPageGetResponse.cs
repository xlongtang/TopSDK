using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WlbItemConsignmentPageGetResponse.
    /// </summary>
    public class WlbItemConsignmentPageGetResponse : TopResponse
    {
        /// <summary>
        /// 条件查询结果总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 代销关系列表
        /// </summary>
        [XmlArray("wlb_consign_ments")]
        [XmlArrayItem("wlb_consign_ment")]
        public List<WlbConsignMent> WlbConsignMents { get; set; }
    }
}
