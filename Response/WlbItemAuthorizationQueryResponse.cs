using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WlbItemAuthorizationQueryResponse.
    /// </summary>
    public class WlbItemAuthorizationQueryResponse : TopResponse
    {
        /// <summary>
        /// 授权关系列表
        /// </summary>
        [XmlArray("authorization_list")]
        [XmlArrayItem("wlb_authorization")]
        public List<WlbAuthorization> AuthorizationList { get; set; }

        /// <summary>
        /// 结果总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
