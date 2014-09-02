using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// JaeClientRelationShowfollowbuttonResponse.
    /// </summary>
    public class JaeClientRelationShowfollowbuttonResponse : TopResponse
    {
        /// <summary>
        /// 无返回结果
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
