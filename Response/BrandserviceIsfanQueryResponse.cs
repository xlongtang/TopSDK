using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// BrandserviceIsfanQueryResponse.
    /// </summary>
    public class BrandserviceIsfanQueryResponse : TopResponse
    {
        /// <summary>
        /// 返回相应的数值
        /// </summary>
        [XmlElement("value")]
        public bool Value { get; set; }
    }
}
