using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// MbcPromotionUseResponse.
    /// </summary>
    public class MbcPromotionUseResponse : TopResponse
    {
        /// <summary>
        /// 淘宝这边生成的唯一ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 0：失败；1：成功
        /// </summary>
        [XmlElement("ret_code")]
        public long RetCode { get; set; }
    }
}
