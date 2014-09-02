using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaCreativeDeleteResponse.
    /// </summary>
    public class SimbaCreativeDeleteResponse : TopResponse
    {
        /// <summary>
        /// 被删除的创意对象
        /// </summary>
        [XmlElement("creative")]
        public Creative Creative { get; set; }
    }
}
