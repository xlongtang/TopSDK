using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// RoomType Data Structure.
    /// </summary>
    [Serializable]
    public class RoomType : TopObject
    {
        /// <summary>
        /// 某卖家提供的房型别名(注：该字段将被废弃)
        /// </summary>
        [XmlElement("alias_name")]
        public string AliasName { get; set; }

        /// <summary>
        /// 房型审核被否决的原因
        /// </summary>
        [XmlElement("audit_deny_reason")]
        public string AuditDenyReason { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 酒店id
        /// </summary>
        [XmlElement("hid")]
        public long Hid { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("modified")]
        public string Modified { get; set; }

        /// <summary>
        /// 房型名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 房型id
        /// </summary>
        [XmlElement("rid")]
        public long Rid { get; set; }

        /// <summary>
        /// 状态。0：待审核，1：正常（审核通过），2：审核否决，3：停售
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }
    }
}
