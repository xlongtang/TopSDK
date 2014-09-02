using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// JaeClientContextGetnetworkstatusResponse.
    /// </summary>
    public class JaeClientContextGetnetworkstatusResponse : TopResponse
    {
        /// <summary>
        /// 获取网络类型
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
