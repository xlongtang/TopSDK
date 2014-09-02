using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// TmcUser Data Structure.
    /// </summary>
    [Serializable]
    public class TmcUser : TopObject
    {
        /// <summary>
        /// 用户首次开通时间
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 接收用户消息的组名
        /// </summary>
        [XmlElement("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// 用户授权是否有效，true表示授权有效，false表示授权过期
        /// </summary>
        [XmlElement("is_valid")]
        public bool IsValid { get; set; }

        /// <summary>
        /// 用户最后开通时间
        /// </summary>
        [XmlElement("modified")]
        public string Modified { get; set; }

        /// <summary>
        /// 用户开通的消息类型列表。如果为空表示应用开通的所有类型
        /// </summary>
        [XmlArray("topics")]
        [XmlArrayItem("string")]
        public List<string> Topics { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_id")]
        public long UserId { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        [XmlElement("user_nick")]
        public string UserNick { get; set; }
    }
}
