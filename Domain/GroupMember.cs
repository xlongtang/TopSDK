using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// GroupMember Data Structure.
    /// </summary>
    [Serializable]
    public class GroupMember : TopObject
    {
        /// <summary>
        /// 组编号
        /// </summary>
        [XmlElement("group_id")]
        public long GroupId { get; set; }

        /// <summary>
        /// 组名称
        /// </summary>
        [XmlElement("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// 组成员列表，逗号分隔
        /// </summary>
        [XmlElement("member_list")]
        public string MemberList { get; set; }
    }
}
