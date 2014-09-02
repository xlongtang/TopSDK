using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaCreativeAddResponse.
    /// </summary>
    public class SimbaCreativeAddResponse : TopResponse
    {
        /// <summary>
        /// 新增加的创意对象
        /// </summary>
        [XmlElement("creative")]
        public Creative Creative { get; set; }
    }
}
