using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// Category Data Structure.
    /// </summary>
    [Serializable]
    public class Category : TopObject
    {
        /// <summary>
        /// 类目id
        /// </summary>
        [XmlElement("cateid")]
        public long Cateid { get; set; }

        /// <summary>
        /// 类目名称
        /// </summary>
        [XmlElement("catename")]
        public string Catename { get; set; }
    }
}
