using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// DeliveryTemplateAddResponse.
    /// </summary>
    public class DeliveryTemplateAddResponse : TopResponse
    {
        /// <summary>
        /// 模板对象
        /// </summary>
        [XmlElement("delivery_template")]
        public DeliveryTemplate DeliveryTemplate { get; set; }
    }
}
