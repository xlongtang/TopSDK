using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// ScitemAddResponse.
    /// </summary>
    public class ScitemAddResponse : TopResponse
    {
        /// <summary>
        /// 后台商品信息
        /// </summary>
        [XmlElement("sc_item")]
        public ScItem ScItem { get; set; }
    }
}
