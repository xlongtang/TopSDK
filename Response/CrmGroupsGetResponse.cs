using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// CrmGroupsGetResponse.
    /// </summary>
    public class CrmGroupsGetResponse : TopResponse
    {
        /// <summary>
        /// 查询到的当前卖家的当前页的会员
        /// </summary>
        [XmlArray("groups")]
        [XmlArrayItem("group")]
        public List<Group> Groups { get; set; }

        /// <summary>
        /// 记录总数
        /// </summary>
        [XmlElement("total_result")]
        public long TotalResult { get; set; }
    }
}
