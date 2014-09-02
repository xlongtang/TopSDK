using System;
using System.Xml.Serialization;
using Top.Api;

namespace Aliyun.Api.Domain
{
    /// <summary>
    /// VideoTranscodeJob Data Structure.
    /// </summary>
    [Serializable]
    public class VideoTranscodeJob : TopObject
    {
        /// <summary>
        /// 转码任务ID
        /// </summary>
        [XmlElement("JobId")]
        public string JobId { get; set; }

        /// <summary>
        /// 视频ID
        /// </summary>
        [XmlElement("MediaId")]
        public string MediaId { get; set; }

        /// <summary>
        /// 转码进度0~100
        /// </summary>
        [XmlElement("Percent")]
        public long Percent { get; set; }

        /// <summary>
        /// 转码的状态,1：排队中，2：转码中；3：转码成功，4：转码失败，5：已删除。
        /// </summary>
        [XmlElement("State")]
        public long State { get; set; }

        /// <summary>
        /// 转码模板ID
        /// </summary>
        [XmlElement("TemplateId")]
        public string TemplateId { get; set; }
    }
}
