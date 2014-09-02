using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// SpContentGetalltagResponse.
    /// </summary>
    public class SpContentGetalltagResponse : TopResponse
    {
        /// <summary>
        /// 返回JSON格式的TagName列表
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
