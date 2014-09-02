using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// CrmGrademktMemberAddResponse.
    /// </summary>
    public class CrmGrademktMemberAddResponse : TopResponse
    {
        /// <summary>
        /// 返回操作是否成功
        /// </summary>
        [XmlElement("model")]
        public bool Model { get; set; }
    }
}
