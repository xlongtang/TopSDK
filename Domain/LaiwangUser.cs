using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// LaiwangUser Data Structure.
    /// </summary>
    [Serializable]
    public class LaiwangUser : TopObject
    {
        /// <summary>
        /// 头像URL
        /// </summary>
        [XmlElement("avatar")]
        public string Avatar { get; set; }

        /// <summary>
        /// 头像URL（大幅）
        /// </summary>
        [XmlElement("avatar_big")]
        public string AvatarBig { get; set; }

        /// <summary>
        /// 用户所在城市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 用户性别
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// openid
        /// </summary>
        [XmlElement("openid")]
        public string Openid { get; set; }
    }
}
