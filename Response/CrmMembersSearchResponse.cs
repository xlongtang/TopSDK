using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// CrmMembersSearchResponse.
    /// </summary>
    public class CrmMembersSearchResponse : TopResponse
    {
        /// <summary>
        /// 根据一定条件查询的卖家会员
        /// </summary>
        [XmlArray("members")]
        [XmlArrayItem("crm_member")]
        public List<CrmMember> Members { get; set; }

        /// <summary>
        /// 记录的总条数
        /// </summary>
        [XmlElement("total_result")]
        public long TotalResult { get; set; }
    }
}
