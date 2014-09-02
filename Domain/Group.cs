using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// Group Data Structure.
    /// </summary>
    [Serializable]
    public class Group : TopObject
    {
        /// <summary>
        /// 分组的创建时间
        /// </summary>
        [XmlElement("group_create")]
        public string GroupCreate { get; set; }

        /// <summary>
        /// 分组的id
        /// </summary>
        [XmlElement("group_id")]
        public long GroupId { get; set; }

        /// <summary>
        /// 分组的修改时间
        /// </summary>
        [XmlElement("group_modify")]
        public string GroupModify { get; set; }

        /// <summary>
        /// 分组的名称
        /// </summary>
        [XmlElement("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// 分组所拥有的会员数量,如果返回值为-1，表示当前服务忙。
        /// </summary>
        [XmlElement("member_count")]
        public long MemberCount { get; set; }

        /// <summary>
        /// 分组的状态，1表示正常
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
