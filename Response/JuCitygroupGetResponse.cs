using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// JuCitygroupGetResponse.
    /// </summary>
    public class JuCitygroupGetResponse : TopResponse
    {
        /// <summary>
        /// 生活服务团信息
        /// </summary>
        [XmlElement("group")]
        public GroupData Group { get; set; }
    }
}
