using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// QrcodeDO Data Structure.
    /// </summary>
    [Serializable]
    public class QrcodeDO : TopObject
    {
        /// <summary>
        /// 二维码所属渠道ID
        /// </summary>
        [XmlElement("channel_id")]
        public long ChannelId { get; set; }

        /// <summary>
        /// 二维码对应的渠道名
        /// </summary>
        [XmlElement("channel_name")]
        public string ChannelName { get; set; }

        /// <summary>
        /// 二维码的矢量图下载地址，只有设置入参need_eps为true且style不为官方模板时，才返回值
        /// </summary>
        [XmlElement("eps_url")]
        public string EpsUrl { get; set; }

        /// <summary>
        /// 二维码id
        /// </summary>
        [XmlElement("qrcode_id")]
        public long QrcodeId { get; set; }

        /// <summary>
        /// 二维码图片链接
        /// </summary>
        [XmlElement("qrcode_url")]
        public string QrcodeUrl { get; set; }

        /// <summary>
        /// 二维码的短地址，每一个原始地址都会生成一个短地址
        /// </summary>
        [XmlElement("short_url")]
        public string ShortUrl { get; set; }

        /// <summary>
        /// 二维码扫码后访问的目的地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
