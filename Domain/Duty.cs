using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// Duty Data Structure.
    /// </summary>
    [Serializable]
    public class Duty : TopObject
    {
        /// <summary>
        /// 职务ID
        /// </summary>
        [XmlElement("duty_id")]
        public long DutyId { get; set; }

        /// <summary>
        /// 职务级别
        /// </summary>
        [XmlElement("duty_level")]
        public long DutyLevel { get; set; }

        /// <summary>
        /// 职务名称
        /// </summary>
        [XmlElement("duty_name")]
        public string DutyName { get; set; }
    }
}
