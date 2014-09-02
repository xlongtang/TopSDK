using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// HanoiFunctionAddResponse.
    /// </summary>
    public class HanoiFunctionAddResponse : TopResponse
    {
        /// <summary>
        /// 添加成功，返回function的id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }
    }
}
