using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// CrmGrademktMemberDetailQueryResponse.
    /// </summary>
    public class CrmGrademktMemberDetailQueryResponse : TopResponse
    {
        /// <summary>
        /// totalCount为记录总数
        /// </summary>
        [XmlElement("model")]
        public string Model { get; set; }
    }
}
