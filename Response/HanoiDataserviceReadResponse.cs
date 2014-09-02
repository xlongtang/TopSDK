using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// HanoiDataserviceReadResponse.
    /// </summary>
    public class HanoiDataserviceReadResponse : TopResponse
    {
        /// <summary>
        /// json格式的kv对。k是属性的key，v是属性值。
        /// </summary>
        [XmlElement("values")]
        public string Values { get; set; }
    }
}
