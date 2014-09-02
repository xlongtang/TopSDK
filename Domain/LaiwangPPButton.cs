using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// LaiwangPPButton Data Structure.
    /// </summary>
    [Serializable]
    public class LaiwangPPButton : TopObject
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
        /// 二级按钮列表
        /// </summary>
        [XmlArray("sub_button")]
        [XmlArrayItem("laiwang_p_p_sub_button")]
        public List<LaiwangPPSubButton> SubButton { get; set; }

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
