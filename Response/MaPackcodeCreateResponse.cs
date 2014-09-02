using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// MaPackcodeCreateResponse.
    /// </summary>
    public class MaPackcodeCreateResponse : TopResponse
    {
        /// <summary>
        /// 生成包裹码二维码图片链接
        /// </summary>
        [XmlElement("qrcodeurl")]
        public string Qrcodeurl { get; set; }
    }
}
