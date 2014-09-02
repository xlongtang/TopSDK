using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// DocumentVO Data Structure.
    /// </summary>
    [Serializable]
    public class DocumentVO : TopObject
    {
        /// <summary>
        /// 档案的编码信息
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [XmlElement("dscription")]
        public string Dscription { get; set; }

        /// <summary>
        /// 唯一标识
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 档案的名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
