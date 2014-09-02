using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallBrandcatPropinputGetResponse.
    /// </summary>
    public class TmallBrandcatPropinputGetResponse : TopResponse
    {
        /// <summary>
        /// 属性输入特征
        /// </summary>
        [XmlElement("property_input")]
        public PropertyInputDO PropertyInput { get; set; }
    }
}
