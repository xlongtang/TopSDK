using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// WirelessQrcodeGetResponse.
    /// </summary>
    public class WirelessQrcodeGetResponse : TopResponse
    {
        /// <summary>
        /// 二维码图片地址
        /// </summary>
        [XmlElement("module")]
        public string Module { get; set; }
    }
}
