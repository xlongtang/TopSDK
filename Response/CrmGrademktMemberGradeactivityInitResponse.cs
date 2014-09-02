using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// CrmGrademktMemberGradeactivityInitResponse.
    /// </summary>
    public class CrmGrademktMemberGradeactivityInitResponse : TopResponse
    {
        /// <summary>
        /// json格式
        /// </summary>
        [XmlElement("module")]
        public bool Module { get; set; }
    }
}
