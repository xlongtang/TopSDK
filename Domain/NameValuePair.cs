using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// NameValuePair Data Structure.
    /// </summary>
    [Serializable]
    public class NameValuePair : TopObject
    {
        /// <summary>
        /// 名值对的编码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 名值对的文本描述
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
