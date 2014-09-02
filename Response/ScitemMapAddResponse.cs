using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// ScitemMapAddResponse.
    /// </summary>
    public class ScitemMapAddResponse : TopResponse
    {
        /// <summary>
        /// 接口调用返回结果信息：商家编码
        /// </summary>
        [XmlElement("outer_code")]
        public string OuterCode { get; set; }
    }
}
