using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// SpServiceSiteGetResponse.
    /// </summary>
    public class SpServiceSiteGetResponse : TopResponse
    {
        /// <summary>
        /// 返回站点信息的Json字符串
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
