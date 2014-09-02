using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// SpContentGetcountResponse.
    /// </summary>
    public class SpContentGetcountResponse : TopResponse
    {
        /// <summary>
        /// 返回记录数
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
