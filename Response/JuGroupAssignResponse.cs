using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// JuGroupAssignResponse.
    /// </summary>
    public class JuGroupAssignResponse : TopResponse
    {
        /// <summary>
        /// 返回单个组信息
        /// </summary>
        [XmlElement("group")]
        public GroupData Group { get; set; }
    }
}
