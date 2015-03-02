using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// SizeMappingTemplate Data Structure.
    /// </summary>
    [Serializable]
    public class SizeMappingTemplate : TopObject
    {
        /// <summary>
        /// 尺码表模板内容，格式为"尺码值:维度名称:数值,尺码值:维度名称:数值"。其中，数值的单位，长度单位为厘米（cm），体重单位为公斤（kg）。
        /// </summary>
        [XmlElement("template_content")]
        public string TemplateContent { get; set; }

        /// <summary>
        /// 尺码表模板ID
        /// </summary>
        [XmlElement("template_id")]
        public long TemplateId { get; set; }

        /// <summary>
        /// 尺码表模板名称
        /// </summary>
        [XmlElement("template_name")]
        public string TemplateName { get; set; }
    }
}
