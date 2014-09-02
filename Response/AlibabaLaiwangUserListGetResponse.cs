using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// AlibabaLaiwangUserListGetResponse.
    /// </summary>
    public class AlibabaLaiwangUserListGetResponse : TopResponse
    {
        /// <summary>
        /// 关注者列表
        /// </summary>
        [XmlElement("users")]
        public LaiwangUsers Users { get; set; }
    }
}
