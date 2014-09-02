using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// CrmMembersIncrementGetResponse.
    /// </summary>
    public class CrmMembersIncrementGetResponse : TopResponse
    {
        /// <summary>
        /// 返回当前页的会员列表
        /// </summary>
        [XmlArray("members")]
        [XmlArrayItem("basic_member")]
        public List<BasicMember> Members { get; set; }

        /// <summary>
        /// 记录的总条数
        /// </summary>
        [XmlElement("total_result")]
        public long TotalResult { get; set; }
    }
}
