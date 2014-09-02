using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// LaiwangPPSubButton Data Structure.
    /// </summary>
    [Serializable]
    public class LaiwangPPSubButton : TopObject
    {
        /// <summary>
        /// 按钮的key.
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 公众账号的菜单名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 按钮点击后跳转的目的地址.
        /// </summary>
        [XmlElement("target")]
        public string Target { get; set; }

        /// <summary>
        /// 按钮的类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 按钮跳转的url
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
