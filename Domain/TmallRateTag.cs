using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TmallRateTag Data Structure.
    /// </summary>
    [Serializable]
    public class TmallRateTag : TopObject
    {
        /// <summary>
        /// 表示标签的极性，正极true，负极false
        /// </summary>
        [XmlElement("posi")]
        public bool Posi { get; set; }

        /// <summary>
        /// 表示标签的名称
        /// </summary>
        [XmlElement("tag_name")]
        public string TagName { get; set; }
    }
}
