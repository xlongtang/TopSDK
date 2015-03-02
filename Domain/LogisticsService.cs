using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// LogisticsService Data Structure.
    /// </summary>
    [Serializable]
    public class LogisticsService : TopObject
    {
        /// <summary>
        /// 服务编码
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [XmlElement("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 服务类型值，json格式表示
        /// </summary>
        [XmlElement("service_value4_json")]
        public string ServiceValue4Json { get; set; }
    }
}
