using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// AreaOption Data Structure.
    /// </summary>
    [Serializable]
    public class AreaOption : TopObject
    {
        /// <summary>
        /// 地域id
        /// </summary>
        [XmlElement("area_id")]
        public long AreaId { get; set; }

        /// <summary>
        /// 地域级别，目前自治区、省、直辖市是1，其他城市、地区是2
        /// </summary>
        [XmlElement("level")]
        public long Level { get; set; }

        /// <summary>
        /// 地域名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 父地域id，若该字段为0表示该行政区为顶层，例如像北京，国外等。
        /// </summary>
        [XmlElement("parent_id")]
        public long ParentId { get; set; }
    }
}
