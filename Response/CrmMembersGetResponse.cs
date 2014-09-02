using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// CrmMembersGetResponse.
    /// </summary>
    public class CrmMembersGetResponse : TopResponse
    {
        /// <summary>
        /// 根据一定条件查询到卖家的会员
        /// </summary>
        [XmlArray("members")]
        [XmlArrayItem("basic_member")]
        public List<BasicMember> Members { get; set; }

        /// <summary>
        /// 记录总数
        /// </summary>
        [XmlElement("total_result")]
        public long TotalResult { get; set; }
    }
}
