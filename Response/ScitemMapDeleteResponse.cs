using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// ScitemMapDeleteResponse.
    /// </summary>
    public class ScitemMapDeleteResponse : TopResponse
    {
        /// <summary>
        /// 失效条数
        /// </summary>
        [XmlElement("module")]
        public long Module { get; set; }
    }
}
