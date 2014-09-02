using System;
using System.Xml.Serialization;
using Top.Api;

namespace Aliyun.Api.Domain
{
    /// <summary>
    /// TranscodeOutput Data Structure.
    /// </summary>
    [Serializable]
    public class TranscodeOutput : TopObject
    {
        /// <summary>
        /// 转码成功后输出文件地址
        /// </summary>
        [XmlElement("OutputFileUrl")]
        public string OutputFileUrl { get; set; }

        /// <summary>
        /// 转码模板ID
        /// </summary>
        [XmlElement("TemplateId")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 视频固有特征信息
        /// </summary>
        [XmlElement("VideoFeatures")]
        public VideoFeatures VideoFeatures { get; set; }
    }
}
