using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// IncrementAuthorizeMessageGetResponse.
    /// </summary>
    public class IncrementAuthorizeMessageGetResponse : TopResponse
    {
        /// <summary>
        /// 代表是否有下一页
        /// </summary>
        [XmlElement("has_next")]
        public bool HasNext { get; set; }

        /// <summary>
        /// 消息的json串
        /// </summary>
        [XmlArray("messages")]
        [XmlArrayItem("string")]
        public List<string> Messages { get; set; }
    }
}
