using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// LoginUser Data Structure.
    /// </summary>
    [Serializable]
    public class LoginUser : TopObject
    {
        /// <summary>
        /// 入驻时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 会员NICK
        /// </summary>
        [XmlElement("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 分销用户ID
        /// </summary>
        [XmlElement("user_id")]
        public long UserId { get; set; }

        /// <summary>
        /// 分销用户类型(1:分销商，2:供应商，3:非分销平台用户)
        /// </summary>
        [XmlElement("user_type")]
        public string UserType { get; set; }
    }
}
