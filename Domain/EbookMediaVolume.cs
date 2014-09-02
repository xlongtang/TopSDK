using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// EbookMediaVolume Data Structure.
    /// </summary>
    [Serializable]
    public class EbookMediaVolume : TopObject
    {
        /// <summary>
        /// 卷的添加时间
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 电子书卷ID
        /// </summary>
        [XmlElement("volume_id")]
        public long VolumeId { get; set; }
    }
}
