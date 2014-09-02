using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TmallRateTagDetail Data Structure.
    /// </summary>
    [Serializable]
    public class TmallRateTagDetail : TopObject
    {
        /// <summary>
        /// 反应该标签的评价数量
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 标签的极性：1正极 -1负极
        /// </summary>
        [XmlElement("posi")]
        public bool Posi { get; set; }

        /// <summary>
        /// 标签名称
        /// </summary>
        [XmlElement("tag_name")]
        public string TagName { get; set; }
    }
}
