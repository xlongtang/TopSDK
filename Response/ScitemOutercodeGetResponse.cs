using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// ScitemOutercodeGetResponse.
    /// </summary>
    public class ScitemOutercodeGetResponse : TopResponse
    {
        /// <summary>
        /// 后台商品
        /// </summary>
        [XmlElement("sc_item")]
        public ScItem ScItem { get; set; }
    }
}
