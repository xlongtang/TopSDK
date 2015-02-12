using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// LogisticServiceTag Data Structure.
    /// </summary>
    [Serializable]
    public class LogisticServiceTag : TopObject
    {
        /// <summary>
        /// 物流服务下的标签属性,多个标签之间有";"分隔
        /// </summary>
        [XmlElement("service_tag")]
        public string ServiceTag { get; set; }

        /// <summary>
        /// 消费者选快递请直接判断service_tag是否包含companyCode。而不要判断service_type
        /// </summary>
        [XmlElement("service_type")]
        public string ServiceType { get; set; }
    }
}
