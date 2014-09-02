using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// CrmGrademktMemberDetailCreateResponse.
    /// </summary>
    public class CrmGrademktMemberDetailCreateResponse : TopResponse
    {
        /// <summary>
        /// json格式
        /// </summary>
        [XmlElement("module")]
        public bool Module { get; set; }
    }
}
