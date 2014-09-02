using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// HanoiFunctionUpdateResponse.
    /// </summary>
    public class HanoiFunctionUpdateResponse : TopResponse
    {
        /// <summary>
        /// 更新成功返回true
        /// </summary>
        [XmlElement("model")]
        public bool Model { get; set; }
    }
}
