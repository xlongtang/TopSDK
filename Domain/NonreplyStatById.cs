using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// NonreplyStatById Data Structure.
    /// </summary>
    [Serializable]
    public class NonreplyStatById : TopObject
    {
        /// <summary>
        /// 客服人员未回复的客户ID
        /// </summary>
        [XmlElement("non_reply_customId")]
        public string NonReplyCustomId { get; set; }

        /// <summary>
        /// 客服未回复数
        /// </summary>
        [XmlElement("non_reply_num")]
        public long NonReplyNum { get; set; }

        /// <summary>
        /// 客服人员ID
        /// </summary>
        [XmlElement("service_staff_id")]
        public string ServiceStaffId { get; set; }
    }
}
