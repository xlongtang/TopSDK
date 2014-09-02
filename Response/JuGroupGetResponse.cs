using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// JuGroupGetResponse.
    /// </summary>
    public class JuGroupGetResponse : TopResponse
    {
        /// <summary>
        /// 组信息的返回对象
        /// </summary>
        [XmlElement("group")]
        public GroupData Group { get; set; }
    }
}
