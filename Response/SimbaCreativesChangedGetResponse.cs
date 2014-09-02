using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaCreativesChangedGetResponse.
    /// </summary>
    public class SimbaCreativesChangedGetResponse : TopResponse
    {
        /// <summary>
        /// 广告创意分页对象
        /// </summary>
        [XmlElement("creatives")]
        public CreativePage Creatives { get; set; }
    }
}
