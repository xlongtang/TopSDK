using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// ScitemGetResponse.
    /// </summary>
    public class ScitemGetResponse : TopResponse
    {
        /// <summary>
        /// 后端商品
        /// </summary>
        [XmlElement("sc_item")]
        public ScItem ScItem { get; set; }
    }
}
