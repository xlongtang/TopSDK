using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// ServiceItemProperty Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceItemProperty : TopObject
    {
        /// <summary>
        /// 基础价格
        /// </summary>
        [XmlElement("basic_price")]
        public string BasicPrice { get; set; }

        /// <summary>
        /// 质检服务简介
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 属性列表
        /// </summary>
        [XmlArray("item_property_values")]
        [XmlArrayItem("item_property_values")]
        public List<ItemPropertyValues> ItemPropertyValues { get; set; }

        /// <summary>
        /// 服务商的nick
        /// </summary>
        [XmlElement("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 服务收费项代码
        /// </summary>
        [XmlElement("service_item_code")]
        public string ServiceItemCode { get; set; }

        /// <summary>
        /// 服务收费项名称
        /// </summary>
        [XmlElement("service_item_name")]
        public string ServiceItemName { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [XmlElement("service_name")]
        public string ServiceName { get; set; }
    }
}
