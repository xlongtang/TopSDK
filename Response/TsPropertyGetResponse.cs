using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TsPropertyGetResponse.
    /// </summary>
    public class TsPropertyGetResponse : TopResponse
    {
        /// <summary>
        /// 服务收费项相关属性对象
        /// </summary>
        [XmlElement("service_item_property")]
        public ServiceItemProperty ServiceItemProperty { get; set; }
    }
}
