using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// WlbItemAuthorizationAddResponse.
    /// </summary>
    public class WlbItemAuthorizationAddResponse : TopResponse
    {
        /// <summary>
        /// 授权规则ID列表
        /// </summary>
        [XmlArray("rule_id_list")]
        [XmlArrayItem("number")]
        public List<long> RuleIdList { get; set; }
    }
}
