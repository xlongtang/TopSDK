using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// WaybillProductType Data Structure.
    /// </summary>
    [Serializable]
    public class WaybillProductType : TopObject
    {
        /// <summary>
        /// 物流产品类型编码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 物流产品类型名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 物流服务类型列表
        /// </summary>
        [XmlArray("service_types")]
        [XmlArrayItem("waybill_service_type")]
        public List<WaybillServiceType> ServiceTypes { get; set; }
    }
}
