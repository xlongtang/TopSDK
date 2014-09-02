using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WangwangEserviceGroupmemberGetResponse.
    /// </summary>
    public class WangwangEserviceGroupmemberGetResponse : TopResponse
    {
        /// <summary>
        /// 组及其成员列表
        /// </summary>
        [XmlArray("group_member_list")]
        [XmlArrayItem("group_member")]
        public List<GroupMember> GroupMemberList { get; set; }
    }
}
