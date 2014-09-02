using System;
using System.Xml.Serialization;
using Top.Api;

namespace Aliyun.Api.Domain
{
    /// <summary>
    /// TranscodeTemplate Data Structure.
    /// </summary>
    [Serializable]
    public class TranscodeTemplate : TopObject
    {
        /// <summary>
        /// 转码模板描述
        /// </summary>
        [XmlElement("Description")]
        public string Description { get; set; }

        /// <summary>
        /// 转码模板ID
        /// </summary>
        [XmlElement("TemplateId")]
        public string TemplateId { get; set; }
    }
}
