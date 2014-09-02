using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// EbookmediaVolumeAddOrUpdateResponse.
    /// </summary>
    public class EbookmediaVolumeAddOrUpdateResponse : TopResponse
    {
        /// <summary>
        /// 电子书卷信息
        /// </summary>
        [XmlElement("ebook_volume")]
        public EbookMediaVolume EbookVolume { get; set; }
    }
}
